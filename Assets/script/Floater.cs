using UnityEngine;

public class Floater : MonoBehaviour {

    public Rigidbody body;
    public float waterLevel;
    public float floatHeight;
    public float bounceDamp;
    public Vector3 centerOffset;

    private float forceFactor;
    private Vector3 actionPoint;
    private Vector3 upLift;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        Debug.Log(transform.TransformDirection(centerOffset));
        actionPoint = transform.position + transform.TransformDirection(centerOffset);
        forceFactor = 1f - ((actionPoint.y -waterLevel) / floatHeight);

        if (forceFactor > 0f)
        {
            upLift = -Physics.gravity * (forceFactor - body.velocity.y * bounceDamp);
            body.AddForceAtPosition(upLift, actionPoint);
        }
    }
}
