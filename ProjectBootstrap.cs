using UnityEngine;

public class ProjectBootstrap : MonoBehaviour
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    private static void CreatePrototype()
    {
        if (Object.FindObjectOfType<PrototypeSceneBuilder>() != null) return;
        GameObject root = new GameObject("Cricket Card Boli Battle Bootstrap");
        root.AddComponent<PrototypeSceneBuilder>();
        root.AddComponent<CoinWallet>();
    }
}
