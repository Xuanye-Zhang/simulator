/**
 * Copyright (c) 2019 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using UnityEngine;
using System.Collections.Generic;

namespace Simulator.Api.Commands
{
    class VehicleSafeFollowWaypoints : ICommand
    {
        public string Name => "vehicle/safe_follow_waypoints";

        public void Execute(JSONNode args)
        {
            var reqUUID = args["reqUUID"].Value;
            var uid = args["uid"].Value;
            var waypoints = args["waypoints"].AsArray;
            var loop = args["loop"];
            var api = ApiManager.Instance;

            if (waypoints.Count == 0)
            {
                api.SendError(this, $"Waypoint list is empty", reqUUID);
                return;
            }
            
            if (api.Agents.TryGetValue(uid, out GameObject obj))
            {
                var npc = obj.GetComponent<NPCController>();
                if (npc == null)
                {
                    api.SendError(this, $"Agent '{uid}' is not a NPC agent", reqUUID);
                    return;
                }

                var wp = new List<DriveWaypoint>();
                for (int i=0; i< waypoints.Count; i++)
                {
                    var deactivate = waypoints[i]["deactivate"];
                    var ts = waypoints[i]["timestamp"];
                    // TANG YUN UPDATE -- BEGIN                  
                    wp.Add(new DriveWaypoint()
                    {
                        Position = SimulatorManager.Instance.MapManager.FixPositionAltitude(waypoints[i]["position"].ReadVector3(), 0.01f),
                        Speed = waypoints[i]["speed"].AsFloat,
                        Angle = waypoints[i]["angle"].ReadVector3(),
                        Idle = waypoints[i]["idle"].AsFloat,
                        Deactivate = deactivate.IsBoolean ? deactivate.AsBool : false,
                        TriggerDistance = waypoints[i]["trigger_distance"].AsFloat,
                        TimeStamp = (ts == null) ? -1 : waypoints[i]["timestamp"].AsFloat,
                        Trigger = WaypointTrigger.DeserializeTrigger(waypoints[i]["trigger"])
                    });
                    // TANG YUN UPDATE -- END
                }

                var loopValue = loop.IsBoolean ? loop.AsBool : false;
                var waypointFollow = npc.SetBehaviour<NPCWaypointSafeBehaviour>();
                waypointFollow.SetFollowWaypoints(wp, loop); // TODO use NPCController to init waypoint data
                api.RegisterAgentWithWaypoints(npc.gameObject);
                api.SendResultWithReq(null, reqUUID);
            }
            else
            {
                api.SendError(this, $"Agent '{uid}' not found", reqUUID);
            }
        }

    }
    
}
