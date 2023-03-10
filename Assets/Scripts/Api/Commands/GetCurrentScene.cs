/**
 * Copyright (c) 2019-2020 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using SimpleJSON;

namespace Simulator.Api.Commands
{
    class GetCurrentScene : ICommand
    {
        public string Name => "simulator/current_scene";

        public void Execute(JSONNode args)
        {
            var reqUUID = args["reqUUID"].Value;
            var api = ApiManager.Instance;
            var scene = api.CurrentScene;
            if (string.IsNullOrEmpty(scene))
            {
                api.SendResultWithReq(null, reqUUID);
            }
            else
            {
                api.SendResultWithReq(new JSONString(scene), reqUUID);
            }
        }
    }
}
