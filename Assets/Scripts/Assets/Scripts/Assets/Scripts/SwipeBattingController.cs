
using UnityEngine;

public class SwipeBattingController : MonoBehaviour
{
    public float hitForce = 12f;
    public float upwardForce = 4f;

    public void HitBall(GameObject ball)
    {
        if (ball == null) return;

        Rigidbody ballBody = ball.GetComponent<Rigidbody>();

        if (ballBody == null) return;

        Vector3 hitDirection = transform.forward + Vector3.up * 0.3f;

        ballBody.AddForce(
            hitDirection.normalized * hitForce +
            Vector3.up * upwardForce,
            ForceMode.Impulse
        );
    }
}
