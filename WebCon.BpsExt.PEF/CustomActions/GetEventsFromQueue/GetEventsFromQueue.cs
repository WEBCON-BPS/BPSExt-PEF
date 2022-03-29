using System;
using System.Diagnostics;
using System.Text;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;
using WebCon.BpsExt.PEF.CustomActions.Models;
using WebCon.BpsExt.PEF.CustomActions.Utils;
using WebCon.BpsExt.PEF.CustomActions.GetEventsFromQueue.MessageHelpers;

namespace WebCon.BpsExt.PEF.CustomActions.GetEventsFromQueue
{
    public class GetEventsFromQueue : CustomAction<GetEventsFromQueueConfig>
    {
        public override ExecutionType ActionExecutionType { get => ExecutionType.AfterTransaction;}
        public override ActionTriggers AvailableActionTriggers => ActionTriggers.Recurrent;

        StringBuilder _logger = new StringBuilder();

        public override void Run(RunCustomActionParams args)
        {
            RunWithoutDocumentContext(new RunCustomActionWithoutContextParams(args));
        }

        public override void RunWithoutDocumentContext(RunCustomActionWithoutContextParams args)
        {
            var timer = new Stopwatch();
            var counter = 0;
            try
            {
                timer.Start();
                var apiHelper = new QueueApiHelper(Configuration, args.Context, _logger);
                var messageHelper = new MessageHelper(Configuration, args.Context, _logger, apiHelper);
                while (counter < Configuration.MaxElementsToProcess && timer.ElapsedMilliseconds < (Configuration.MaxExecutionTime * 1000))
                {
                    _logger.AppendLine($"Downloading message {counter}");
                    var message = apiHelper.GetMessageFromQueue(out var noMessages);
                    if (noMessages)
                    {
                        _logger.AppendLine("Queue is empty, action execution aborted");
                        break;
                    }
                    if (message != null)
                        ProcessMessage(message, messageHelper);
                    counter++;
                }
            }
            catch (Exception ex)
            {
                _logger.AppendLine(ex.ToString());
                args.Message = ex.Message;
                args.HasErrors = true;
            }
            finally
            {
                args.LogMessage = _logger.ToString();
                args.Context.PluginLogger.AppendInfo(_logger.ToString());
            }
        }

        private void ProcessMessage(string message, MessageHelper messageHelper)
        {
            if (message.TryParseJson<ReceivedOrSendDocumentStatusChangedMessage>(out var statusChangedResult, out var messageType))
                messageHelper.ProcessReceivedOrSentDocumentStatusChangedMessage(statusChangedResult, messageType, message);
            else if (message.TryParseJson<DocumentReceivedMessage>(out var documentReceivedResult, out messageType))
                messageHelper.ProcessDocumentReceivedMessage(documentReceivedResult, messageType);
            else if (message.TryParseJson<DocumentSentFromOtherSourceMessage>(out var documentSentFromOtherSourceResult, out messageType))
                messageHelper.ProcessDocumentReceivedMessage(documentSentFromOtherSourceResult, messageType);
            else if (message.TryParseJson<SentDocumentErrorMessage>(out var sentDocumentErrorResult, out messageType))
                messageHelper.ProcessSentDocumentErrorMessage(sentDocumentErrorResult, messageType);
            else
                _logger.AppendLine("Could not match the message");
        }
    }
}