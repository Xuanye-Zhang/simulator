/**
 * Copyright (c) 2020 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using UnityEngine;

namespace Simulator.Api.Commands
{
    class PedestrianSetSpeed : ICommand
    {
        public string Name => "pedestrian/set_speed";

        public void Execute(JSONNode args)
        {
            var reqUUID = args["reqUUID"].Value;
            var uid = args["uid"].Value;
            var api = ApiManager.Instance;

            if (api.Agents.TryGetValue(uid, out GameObject obj))
            {
                var ped = obj.GetComponent<PedestrianController>();
                if (ped == null)
                {
                    api.SendError(this, $"Agent '{uid}' is not a pedestrian", reqUUID);
                    return;
                }

                ped.SetSpeed(args["speed"].AsFloat);

                // api.SendResult(this);
                api.SendResultWithReq(null, reqUUID);
            }
            else
            {
                api.SendError(this, $"Agent '{uid}' not found", reqUUID);
            }
        }
    }
}
