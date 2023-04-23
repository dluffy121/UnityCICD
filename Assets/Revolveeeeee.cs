using UnityEngine;

public class Revolveeeeee : MonoBehaviour
{
    public float speed = 5f;        // Speed of the circular motion
    public float radius = 3f;       // Radius of the circular path
    public Vector3 axis = Vector3.up;  // Axis of rotation

    private Rigidbody rigidBody;   // Reference to the Rigidbody component

    void Start()
    {
        // Get the reference to the Rigidbody component
        rigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Calculate the circular motion in the x-z plane
        float angle = Time.fixedTime * speed;
        float x = Mathf.Cos(angle) * radius;
        float z = Mathf.Sin(angle) * radius;

        // Calculate the target position for the circular motion
        Vector3 targetPosition = new Vector3(x, transform.position.y, z);

        // Calculate the force required to move towards the target position
        Vector3 force = (targetPosition - transform.position) / Time.fixedDeltaTime;

        // Apply the force to the Rigidbody
        rigidBody.AddForce(force, ForceMode.Force);
    }
}
