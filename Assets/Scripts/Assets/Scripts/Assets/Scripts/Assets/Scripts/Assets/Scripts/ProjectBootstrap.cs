
using UnityEngine;

public class ProjectBootstrap : MonoBehaviour
{
    private void Start()
    {
        PrototypeSceneBuilder.CreateGround();
        PrototypeSceneBuilder.CreatePitch();

        Debug.Log("Cricket Card Boli Battle prototype started!");
    }
}
