using System;
using SimpleJSON;
using UnityEngine;
using Simulator.Sensors;
using UnityEngine.Rendering.HighDefinition;
using UnityEngine.SceneManagement;
using Simulator.Web;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Collections.Concurrent;


namespace Simulator.Api.Commands
{
    class AddTest : ICommand
    {
        public string Name => "simulator/add_obstacle";
        public GameObject cubepre;

        //public void Execute(JSONNode args)
        //{

        //    var api = ApiManager.Instance;
        //    var sim = SimulatorManager.Instance;

        //    var a = args["first_arg"].Value;

        //    var b = args["sec_arg"].AsFloat;
        //    b = b + 3;
        //    JSONObject j = new JSONObject();
        //    j.Add(a, b);
        //    ApiManager.Instance.SendResult(this, j);
        //    // JSONObject j = new JSONObject();
        //    // j.Add("hello", "noel");
        //    // ApiManager.Instance.SendResult(this, j);
        //}

        public void Execute(JSONNode args)
        {

            var sim = SimulatorManager.Instance;
            var api = ApiManager.Instance;

            if (sim == null)
            {
                throw new Exception("SimulatorManager not found! Is scene loaded?");
            }

            var name = args["name"].Value;

            var basetype = args["basetype"].AsInt;
            var basescale = args["basescale"].ReadVector3();

            var position = args["state"]["transform"]["position"].ReadVector3();
            var rotation = args["state"]["transform"]["rotation"].ReadVector3();
            var velocity = args["state"]["velocity"].ReadVector3();
            var angular_velocity = args["state"]["angular_velocity"].ReadVector3();

            string uid;
            var argsUid = args["uid"];
            if (argsUid == null)
            {
                uid = System.Guid.NewGuid().ToString();
                // Add uid key to arguments, as it will be distributed to the clients' simulations
                if (Loader.Instance.Network.IsMaster)
                {
                    args.Add("uid", uid);
                }
            }
            else
            {
                uid = argsUid.Value;
            }

            
            JSONArray noiselist = (JSONArray)args["noise"];
            JSONObject j = new JSONObject();
            j.Add(name, uid);
            //foreach (JSONObject noise in noiselist)
            //{
            //    var noisetype = noise["nosietype"].AsInt;
            //    var noisepos = noise["noisepos"].ReadVector3();
            //    j.Add(noisetype.ToString(), noisepos);
            //}
            
            // api.SendResult(this, j);
            api.SendResultWithReq(j, args["reqUUID"].Value);
            var colorData = args["color"].ReadVector3();
            var template = sim.NPCManager.NPCVehicles.Find(obj => obj.Prefab.name == name);
            if (template == null)
            {
                throw new Exception($"Unknown '{name}' NPC name");
            }
            var spawnData = new NPCManager.NPCSpawnData
            {
                Active = true,
                GenId = uid,
                Template = template,
                Position = position,
                Rotation = Quaternion.Euler(rotation),
                Color = colorData == new Vector3(-1, -1, -1) ? sim.NPCManager.GetWeightedRandomColor(template.NPCType) : new Color(colorData.x, colorData.y, colorData.z),
                Seed = sim.NPCManager.NPCSeedGenerator.Next(),
            };

            // MeshFilter meshfilter = gameObject.AddComponent<MeshFilter>();
            // GameObject go = new GameObject();
            // go = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            // // meshfilter.mesh = go.GetComponent<MeshFilter>().mesh;
            // // go.transform.SetParent(transform);
            // go.transform.SetPositionAndRotation(Vector3.zero, Quaternion.identity);
            // go.layer = LayerMask.NameToLayer("NPC");
            // go.tag = "Car";
            // Instantiate(go, go.transform);
            // go.transform.SetPositionAndRotation(spawnData.Position, spawnData.Rotation);
            
            GameObject go = SimulatorManager.Instance.NPCManager.SpawnObs(spawnData, basetype, basescale);
            //go.GetComponent<mesh_generator_test>().generator(0, 3, new Vector3((float)0.73, (float)0.58, (float)0.36), new Vector3((float)0.1, (float)0.1, (float)3), new Vector3(20,30,40));
            foreach (JSONObject noise in noiselist)
            {
                var noisetype = noise["noisetype"].AsInt;
                var noisepos = noise["noisepos"].ReadVector3();
                var noisescale = noise["noisescale"].ReadVector3();
                var noiserotate = noise["noiserotate"].ReadVector3();
                go.GetComponent<mesh_generator>().generator(basetype, noisetype, noisepos, noisescale, noiserotate, go);
            }
            

        }
    }


}
