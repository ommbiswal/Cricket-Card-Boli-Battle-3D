using UnityEngine;

public class PrototypeSceneBuilder : MonoBehaviour
{
    public static void CreateGround()
    {
        GameObject ground = GameObject.CreatePrimitive(PrimitiveType.Plane);
        ground.name = "Cricket Ground";
        ground.transform.position = Vector3.zero;
        ground.transform.localScale = new Vector3(5f, 1f, 5f);

        Renderer renderer = ground.GetComponent<Renderer>();
        renderer.material.color = new Color(0.12f, 0.42f, 0.18f);
    }

    public static void CreatePitch()
    {
        GameObject pitch = GameObject.CreatePrimitive(PrimitiveType.Cube);
        pitch.name = "Cricket Pitch";
        pitch.transform.position = new Vector3(0f, 0.06f, 0f);
        pitch.transform.localScale = new Vector3(2f, 0.1f, 18f);

        Renderer renderer = pitch.GetComponent<Renderer>();
        renderer.material.color = new Color(0.65f, 0.48f, 0.3f);
    }
}
