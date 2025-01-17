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
    class AgentOnWaypointReached : ICommand
    {
        public string Name => "agent/on_waypoint_reached";

        public void Execute(JSONNode args)
        {
            var api = ApiManager.Instance;
            var uid = args["uid"].Value;
            
            var reqUUID = args["reqUUID"].Value;
            if (api.Agents.TryGetValue(uid, out GameObject obj))
            {
                api.Waypoints.Add(obj);
                api.SendResultWithReq(null, reqUUID);
            }
            else
            {
                api.SendError(this, $"Agent '{uid}' not found", reqUUID);
            }
        }
    }
}
