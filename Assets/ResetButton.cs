using UnityEngine;

public class ResetButton : MonoBehaviour
{
    private Vector3 initialPosition;
    private Rigidbody rb;

    private void Start()
    {
        // Store the initial position of the game object
        initialPosition = transform.position;

        // Get the Rigidbody component attached to the game object
        rb = GetComponent<Rigidbody>();
    }

    public void ResetPosition()
    {
        // Reset position
        transform.position = initialPosition;

        // Reset Rigidbody velocities
        if (rb != null)
        {
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
