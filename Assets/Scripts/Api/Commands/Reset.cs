/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using System.Threading.Tasks;

namespace Simulator.Api.Commands
{
    class Reset : IDistributedCommand
    {
        public string Name => "simulator/reset";

        static string reqUUID = "";
        private static async Task ResetAsync(Reset sourceCommand)
        {
            var api = ApiManager.Instance;
            await api.Reset();
            // ApiManager.Instance.SendResult(sourceCommand);
            ApiManager.Instance.SendResultWithReq(null, reqUUID);
        }

        public void Execute(JSONNode args)
        {
            reqUUID = args["reqUUID"].Value;
            var nonBlockingTask = ResetAsync(this);
        }
    }
}
