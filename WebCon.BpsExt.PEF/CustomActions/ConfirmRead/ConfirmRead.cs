using System;
using System.Text;
using WebCon.WorkFlow.SDK.ActionPlugins;
using WebCon.WorkFlow.SDK.ActionPlugins.Model;

namespace WebCon.BpsExt.PEF.CustomActions.ConfirmRead
{
    public class ConfirmRead : CustomAction<ConfirmReadConfig>
    {
        StringBuilder _logger = new StringBuilder();
        public override void Run(RunCustomActionParams args)
        {
            try
            {
                var apiHelper = new ConfirmApiHelper(Configuration, args.Context, _logger);
                if (!apiHelper.ConfirmRead(Configuration.DocumentId))
                    SetErrorMessage(args);
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

        private void SetErrorMessage(RunCustomActionParams args)
        {
            args.Message = "Request failed. For more information check logs.";
            args.HasErrors = true;
        }
    }
}