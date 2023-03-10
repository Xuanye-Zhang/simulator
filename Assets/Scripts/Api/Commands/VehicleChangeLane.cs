/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using UnityEngine;

namespace Simulator.Api.Commands
{
    class VehicleChangeLane : ICommand
    {
        public string Name => "vehicle/change_lane";

        public void Execute(JSONNode args)
        {
            var reqUUID = args["reqUUID"].Value;
            var uid = args["uid"].Value;
            var isLeft = args["isLeftChange"].AsBool;
            var api = ApiManager.Instance;

            if (api.Agents.TryGetValue(uid, out GameObject obj))
            {
                var npc = obj.GetComponent<NPCLaneFollowBehaviour>();
                if (npc == null)
                {
                    api.SendError(this, $"Agent '{uid}' is not a NPC agent with lane capabilities", reqUUID);
                    return;
                }

                npc.ForceLaneChange(isLeft);
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
