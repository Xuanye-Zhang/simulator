/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using UnityEngine;
using System.Collections.Generic;
using System.Linq;
using Simulator.Sensors;

namespace Simulator.Api.Commands
{
    class NPCManualLaneFollowByEgo : ICommand
    {
        public string Name => "npcs/follow_lane_list/config";

        public void Execute(JSONNode args)
        {
            var reqUUID = args["reqUUID"].Value;
            var uid = args["uid"].Value;    // this is Ego UID
            var api = ApiManager.Instance;

            if (!api.Agents.TryGetValue(uid, out GameObject ego))
            {
                api.SendError(this, $"Agent '{uid}' not found", reqUUID);
                return;
            }

            var vc = ego.GetComponent<VehicleController>();

            NPCLaneFollowConfigs npcLaneFollowConfigs = new NPCLaneFollowConfigs(args["destination"].ReadVector3(), args["trigger_dist"].AsFloat);

            var npc_configs = args["npc_configs"].AsArray;
            for(int i = 0; i < npc_configs.Count; i++)
            {
                var npc_config = npc_configs[i];

                if (!api.Agents.TryGetValue(npc_config["uid"].Value, out GameObject npc))
                {
                    continue;
                }

                NPCLaneFollowConfig config = new NPCLaneFollowConfig(npc, npc_config["custom_speed"].AsFloat);
                var laneList = npc_config["lane_list"].AsArray;
                for(int j = 0; j < laneList.Count; j++) {
                    Vector3 start = laneList[j]["start"].ReadVector3();
                    Vector3 end = laneList[j]["end"].ReadVector3();
                    config.lanesToFollow.Add(new LaneToFollow(start, end));
                }

                npcLaneFollowConfigs.configs.Add(config);
            }
            
            vc.npcLaneFollowConfigs = npcLaneFollowConfigs;

            api.SendResultWithReq(null, reqUUID);
        }
    }
}
