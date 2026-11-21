using UnityEngine;

public class SwipeBattingController : MonoBehaviour
{
    [SerializeField] private Transform bat;
    [SerializeField] private float swingDegrees = 105f;
    [SerializeField] private float swingDuration = 0.22f;
    private Vector2 startTouch;
    private float swingTimer;
    private Quaternion restRotation;
    private bool swinging;

    private void Start()
    {
        if (bat != null) restRotation = bat.localRotation;
    }

    private void Update()
    {
        bool ended = false;
        Vector2 endPos = Vector2.zero;

        if (Input.touchCount > 0)
        {
            Touch t = Input.GetTouch(0);
            if (t.phase == TouchPhase.Began) startTouch = t.position;
            if (t.phase == TouchPhase.Ended) { endPos = t.position; ended = true; }
        }
        else
        {
            if (Input.GetMouseButtonDown(0)) startTouch = Input.mousePosition;
            if (Input.GetMouseButtonUp(0)) { endPos = Input.mousePosition; ended = true; }
        }

        if (ended && Mathf.Abs(endPos.x - startTouch.x) + Mathf.Abs(endPos.y - startTouch.y) > 35f)
            StartSwing();

        if (swinging && bat != null)
        {
            swingTimer += Time.deltaTime;
            float t = Mathf.Clamp01(swingTimer / swingDuration);
            bat.localRotation = restRotation * Quaternion.Euler(-swingDegrees * Mathf.Sin(t * Mathf.PI), 0, 0);
            if (t >= 1f) { swinging = false; bat.localRotation = restRotation; }
        }
    }

    private void StartSwing()
    {
        if (bat == null) return;
        swinging = true;
        swingTimer = 0f;
    }
}
