using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCon.BpsExt.PEF.CustomActions.Utils
{
    public static class JsonUtil
    {
        public static bool TryParseJson<T>(this string @this, out T result, out string messageType)
        {
            bool success = true;
            var settings = new JsonSerializerSettings
            {
                Error = (sender, args) => { success = false; args.ErrorContext.Handled = true; },
                MissingMemberHandling = MissingMemberHandling.Error
            };
            var message = JObject.Parse(@this).First;
            result = JsonConvert.DeserializeObject<T>(message.First.ToString(), settings);
            messageType = message.Path;
            return success;
        }

    }
}
