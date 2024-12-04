using UnityEngine;

public class Player : MonoBehaviour
{

    // Add an impulse which produces a change in angular velocity (specified in degrees).
    public void AddTorqueImpulse(float angularChangeInDegrees)
    {
        var body = GetComponent<Rigidbody2D>();
        var impulse = (angularChangeInDegrees * Mathf.Deg2Rad) * body.inertia;

        body.AddTorque(impulse, ForceMode2D.Impulse);
    }
}
