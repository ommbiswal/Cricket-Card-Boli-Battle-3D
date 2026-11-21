using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class CricketBall : MonoBehaviour
{
    private Rigidbody body;
    private void Awake() { body = GetComponent<Rigidbody>(); }

    public void Bowl(Vector3 direction, float speed)
    {
        body.velocity = Vector3.zero;
        body.angularVelocity = Vector3.zero;
        body.AddForce(direction.normalized * speed, ForceMode.VelocityChange);
    }
}
