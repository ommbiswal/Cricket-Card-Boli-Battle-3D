using UnityEngine;

public class PrototypeSceneBuilder : MonoBehaviour
{
    private Material MakeMat(Color c)
    {
        Shader shader = Shader.Find("Universal Render Pipeline/Lit");
        if (shader == null) shader = Shader.Find("Standard");
        Material m = new Material(shader);
        m.color = c;
        return m;
    }

    private void Start()
    {
        BuildScene();
    }

    private void BuildScene()
    {
        var grass = MakeMat(new Color(0.07f, 0.30f, 0.16f));
        var pitchMat = MakeMat(new Color(0.63f, 0.48f, 0.30f));
        var white = MakeMat(Color.white);
        var blue = MakeMat(new Color(0.08f, 0.20f, 0.48f));
        var red = MakeMat(new Color(0.75f, 0.08f, 0.08f));

        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Cricket Ground";
        ground.transform.localScale = new Vector3(8, 1, 8);
        ground.GetComponent<Renderer>().material = grass;

        GameObject pitch = GameObject.CreatePrimitive(PrimitiveType.Cube);
        pitch.name = "Pitch";
        pitch.transform.position = new Vector3(0, 0.04f, 0);
        pitch.transform.localScale = new Vector3(2.5f, 0.08f, 18);
        pitch.GetComponent<Renderer>().material = pitchMat;

        CreateStumps(new Vector3(0, 0, -7.5f), white);
        CreateStumps(new Vector3(0, 0, 7.5f), white);

        GameObject batter = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        batter.name = "Prototype Batter";
        batter.transform.position = new Vector3(0.8f, 1, -5.5f);
        batter.GetComponent<Renderer>().material = blue;

        GameObject bowler = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        bowler.name = "Prototype Bowler";
        bowler.transform.position = new Vector3(-0.8f, 1, 5.7f);
        bowler.GetComponent<Renderer>().material = red;

        GameObject ball = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        ball.name = "Cricket Ball";
        ball.transform.position = new Vector3(0, 0.18f, 4.5f);
        ball.transform.localScale = Vector3.one * 0.28f;
        ball.GetComponent<Renderer>().material = red;
        Rigidbody rb = ball.AddComponent<Rigidbody>();
        rb.mass = 0.16f;
        rb.collisionDetectionMode = CollisionDetectionMode.ContinuousDynamic;

        GameObject bat = GameObject.CreatePrimitive(PrimitiveType.Cube);
        bat.name = "Bat";
        bat.transform.SetParent(batter.transform);
        bat.transform.localPosition = new Vector3(0.45f, 0.1f, 0.45f);
        bat.transform.localRotation = Quaternion.Euler(0, 0, 18);
        bat.transform.localScale = new Vector3(0.18f, 0.9f, 0.12f);
        bat.GetComponent<Renderer>().material = MakeMat(new Color(0.72f, 0.48f, 0.20f));

        var batting = batter.AddComponent<SwipeBattingController>();
        // Attach bat reference through serialized field is intentionally left for Inspector setup.

        GameObject lightObj = new GameObject("Stadium Key Light");
        Light sun = lightObj.AddComponent<Light>();
        sun.type = LightType.Directional;
        sun.intensity = 1.25f;
        lightObj.transform.rotation = Quaternion.Euler(50, -30, 0);

        Camera cam = Camera.main;
        if (cam == null)
        {
            GameObject cameraObj = new GameObject("Main Camera");
            cam = cameraObj.AddComponent<Camera>();
            cameraObj.tag = "MainCamera";
        }
        cam.transform.position = new Vector3(0, 8, -15);
        cam.transform.rotation = Quaternion.Euler(22, 0, 0);
        cam.fieldOfView = 58;
    }

    private void CreateStumps(Vector3 pos, Material mat)
    {
        for (int i = -1; i <= 1; i++)
        {
            GameObject stump = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            stump.name = "Wicket Stump";
            stump.transform.position = pos + new Vector3(i * 0.22f, 0.55f, 0);
            stump.transform.localScale = new Vector3(0.07f, 0.55f, 0.07f);
            stump.GetComponent<Renderer>().material = mat;
        }
    }
}
