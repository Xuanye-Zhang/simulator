/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using UnityEngine;
using Simulator.Bridge;
using Simulator.Components;

namespace Simulator.Api.Commands
{
    class BridgeConnected : ICommand
    {
        public string Name => "vehicle/bridge/connected";

        public void Execute(JSONNode args)
        {
            var uid = args["uid"].Value;
            var api = ApiManager.Instance;
            var reqUUID = args["reqUUID"].Value;

            if (api.Agents.TryGetValue(uid, out GameObject obj))
            {
                var bridge = obj.GetComponentInChildren<BridgeClient>();
                if (bridge == null)
                {
                    api.SendError(this, $"Agent '{uid}' is missing bridge client", reqUUID);
                }
                else
                {
                    var result = new JSONBool(bridge.BridgeStatus == Status.Connected);
                    api.SendResultWithReq(result, reqUUID);
                }
            }
            else
            {
                api.SendError(this, $"Agent '{uid}' not found", reqUUID);
            }
        }
    }
}
