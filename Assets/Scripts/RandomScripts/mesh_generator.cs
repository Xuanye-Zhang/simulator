using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mesh_generator : MonoBehaviour
{
    public GameObject spawnObject;

    Mesh mesh;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    public void gen()
    {
        MeshFilter meshfilter = gameObject.AddComponent<MeshFilter>();
        spawnObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
        //Debug.Log(spawnObject);

        int i = Random.Range(10, 30);
        for (; i >= 0; i--)
        {
            mesh = GetComponent<MeshFilter>().mesh;

            Vector3[] meshPoints = transform.GetComponent<MeshFilter>().mesh.vertices;
            MeshCollider col = gameObject.GetComponent<MeshCollider>();
            float radius = col.bounds.max.magnitude;

            int[] tris = transform.GetComponent<MeshFilter>().mesh.triangles;
            int triStart = Random.Range(0, meshPoints.Length / 3) * 3; // get first index of each triangle

            float a = Random.value;
            float b = Random.value;

            if (a + b >= 1)
            { // reflect back if > 1
                a = 1 - a;
                b = 1 - b;
            }

            Vector3 newPointOnMesh = meshPoints[triStart] + (a * (meshPoints[triStart + 1] - meshPoints[triStart])) + (b * (meshPoints[triStart + 2] - meshPoints[triStart])); // apply formula to get new random point inside triangle

            newPointOnMesh = transform.TransformPoint(newPointOnMesh); // convert back to worldspace

            Vector3 rayOrigin = ((Random.onUnitSphere * radius) + transform.position); // put the ray randomly around the transform

            RaycastHit hitPoint;
            Physics.Raycast(rayOrigin, newPointOnMesh - rayOrigin, out hitPoint, 100f);
            GameObject newObj = Instantiate(spawnObject, hitPoint.transform); //spawn & parent
            newObj.transform.localScale = new Vector3((float)0.1, (float)0.1, (float)3);
            newObj.transform.position = newPointOnMesh;
            newObj.transform.localRotation = Quaternion.FromToRotation(Vector3.one, hitPoint.point);
        }
    }

    public void generator(int noisetype, int number, Vector3 noisescale, Vector3 noiserotate)
    {
        MeshFilter meshfilter = gameObject.AddComponent<MeshFilter>();
        switch (noisetype)
        {
            case 0:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                break;
            case 1:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                break;
            case 2:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                break;
            case 3:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                break;
            case 4:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
                break;
            case 5:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
                break;
        }

        mesh = GetComponent<MeshFilter>().mesh;

        Vector3[] meshPoints = transform.GetComponent<MeshFilter>().mesh.vertices;

        Vector3 newPointOnMesh = (meshPoints[number] + meshPoints[number + 1]) / 2; // middle point
        newPointOnMesh = transform.TransformPoint(newPointOnMesh); // convert back to worldspace

        RaycastHit hitPoint;
        Physics.Raycast(newPointOnMesh, newPointOnMesh, out hitPoint, 100f);
        GameObject newObj = Instantiate(spawnObject, hitPoint.transform); //spawn & parent
        newObj.transform.position = newPointOnMesh;
        //newObj.transform.Rotate(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        newObj.transform.Rotate(noiserotate);
        newObj.transform.localScale = noisescale;


    }

    public void generator(int basetype, int noisetype, Vector3 noisepos, Vector3 noisescale, Vector3 noiserotate)
    {
        switch (noisetype)
        {
            case 0:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                break;
            case 1:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Capsule);
                break;
            case 2:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
                break;
            case 3:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Cube);
                break;
            case 4:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Plane);
                break;
            case 5:
                spawnObject = GameObject.CreatePrimitive(PrimitiveType.Quad);
                break;
        }

        mesh = GetComponent<MeshFilter>().mesh;
        
        GameObject newObj = Instantiate(spawnObject); //spawn & parent
        
        //newObj.transform.Rotate(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        newObj.transform.Rotate(noiserotate);
        newObj.transform.localScale = noisescale;

        Material material = Resources.Load<Material>("Material/SedanGlass");
        Debug.Log(material);
        newObj.GetComponent<MeshRenderer>().material = material;
        switch (basetype)
        {
            case 0:
                newObj.transform.position = (noisepos * (transform.localScale.x / 2) + transform.position);
                break;
            case 1:
                
                break;
            case 2:
                
                break;
            case 3:
                newObj.transform.position = (new Vector3(transform.localScale.x * noisepos.x, transform.localScale.y * noisepos.y, transform.localScale.z * noisepos.z) + transform.position);
                break;
            case 4:
                
                break;
            case 5:
                
                break;
        }


    }

    public void generator(int basetype, int noisetype, Vector3 noisepos, Vector3 noisescale, Vector3 noiserotate, GameObject go)
    {
        switch (noisetype)
        {
            case 0:
                spawnObject = Resources.Load<GameObject>("Material/NoiseSphere");
                break;
            case 1:
                spawnObject = Resources.Load<GameObject>("Material/NoiseCapsule");
                break;
            case 2:
                spawnObject = Resources.Load<GameObject>("Material/NoiseCylinder");
                break;
            case 3:
                spawnObject = Resources.Load<GameObject>("Material/NoiseCube");
                break;
            case 4:
                spawnObject = Resources.Load<GameObject>("Material/NoisePyramid");
                break;
        }

        // spawnObject.transform.position = (new Vector3(go.transform.localScale.x * noisepos.x, go.transform.localScale.y * noisepos.y, go.transform.localScale.z * noisepos.z));
        spawnObject.transform.position = noisepos;
        spawnObject.transform.Rotate(noiserotate);
        spawnObject.transform.localScale = noisescale;
        spawnObject.name = "noise" + noisetype.ToString();
        Instantiate(spawnObject, go.transform); 

        Mesh mesh = spawnObject.GetComponent<MeshFilter>().sharedMesh;
        for (int i = 0; i < mesh.vertices.Length; i++)
        {
            Debug.Log("Vertex " + i + ": " + mesh.vertices[i]);
        }
        

        //newObj.transform.Rotate(Random.Range(-180, 180), Random.Range(-180, 180), Random.Range(-180, 180));
        // spawnObject.transform.Rotate(noiserotate);
        // spawnObject.transform.localScale = noisescale;

        // // Material material = Resources.Load<Material>("Material/SedanGlass");
        // // Debug.Log(material);
        // // spawnObject.GetComponent<MeshRenderer>().material = material;
        // switch (basetype)
        // {
        //     case 0:
        //         spawnObject.transform.position = (noisepos * (go.transform.localScale.x / 2) + go.transform.position);
        //         break;
        //     case 1:
                
        //         break;
        //     case 2:
                
        //         break;
        //     case 3:
        //         // spawnObject.transform.position = (new Vector3(go.transform.localScale.x * noisepos.x, go.transform.localScale.y * noisepos.y, go.transform.localScale.z * noisepos.z) + go.transform.position);
        //         spawnObject.transform.position = (new Vector3(go.transform.localScale.x * noisepos.x, go.transform.localScale.y * noisepos.y, go.transform.localScale.z * noisepos.z));
        //         break;
        //     case 4:
                
        //         break;
        //     case 5:
                
        //         break;
        // }
        // spawnObject.name = "noise";

        // Instantiate(spawnObject, go.transform); //spawn & parent


    }



    // Update is called once per frame
    void Update()
    {

    }
}
