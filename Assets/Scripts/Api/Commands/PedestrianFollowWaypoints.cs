/**
 * Copyright (c) 2019-2021 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;
using UnityEngine;
using System.Collections.Generic;

namespace Simulator.Api.Commands
{
    using System;
    using Utilities;

    class PedestrianWaypoints : ICommand
    {
        public string Name => "pedestrian/follow_waypoints";

        public void Execute(JSONNode args)
        {
            var reqUUID = args["reqUUID"].Value;
            var api = ApiManager.Instance;
            var uid = args["uid"].Value;
            var waypoints = args["waypoints"].AsArray;
            // Try parse the path type, set linear as default
            var pathTypeNode = args["waypoints_path_type"];
            WaypointsPathType waypointsPathType;
            if (pathTypeNode == null)
            {
                waypointsPathType = WaypointsPathType.Linear;
            }
            else if (!Enum.TryParse(pathTypeNode, true, out waypointsPathType))
            {
                waypointsPathType = WaypointsPathType.Linear;
                api.SendError(this, $"Could not parse the waypoints path type \"{waypointsPathType}\".", reqUUID);
            }
            var loop = args["loop"].AsBool;

            if (waypoints.Count == 0)
            {
                api.SendError(this, $"Waypoint list is empty", reqUUID);
                return;
            }
            
            if (api.Agents.TryGetValue(uid, out GameObject obj))
            {
                var ped = obj.GetComponent<PedestrianController>();
                if (ped == null)
                {
                    api.SendError(this, $"Agent '{uid}' is not a pedestrian agent", reqUUID);
                    return;
                }

                var wp = new List<WalkWaypoint>();
                var previousPosition = ped.transform.position;
                for (int i = 0; i < waypoints.Count; i++)
                {
                    // TANG YUN UPDATE -- BEGIN
                    var position = waypoints[i]["position"].ReadVector3();
                    position = SimulatorManager.Instance.MapManager.FixPositionAltitude(position, 0.1f);
                    // TANG YUN UPDATE -- END
                    var angle = waypoints[i].HasKey("angle") ? 
                            waypoints[i]["angle"].ReadVector3() : 
                            Quaternion.LookRotation((position - previousPosition).normalized).eulerAngles;
                    
                    wp.Add(new WalkWaypoint()
                    {
                        Position = position,
                        Angle = angle,
                        Speed = waypoints[i]["speed"].AsFloat,
                        Idle = waypoints[i]["idle"].AsFloat,
                        TriggerDistance = waypoints[i]["trigger_distance"].AsFloat,
                        Trigger = WaypointTrigger.DeserializeTrigger(waypoints[i]["trigger"])
                    });
                    previousPosition = position;
                }

                var waypointBehaviour = ped.SetBehaviour<PedestrianWaypointBehaviour>();
                waypointBehaviour.SetFollowWaypoints(wp, loop, waypointsPathType);
                api.RegisterAgentWithWaypoints(ped.gameObject);
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
