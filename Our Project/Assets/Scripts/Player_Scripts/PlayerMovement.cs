using UnityEngine;

// We made a class "PlayerMovement" that inherits from the 
// "MonoBehaviour" class. We need to look it up!
public class PlayerMovement : MonoBehaviour
{
    // This is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;

    public float forwardForce = 2000F;
    public float sidewaysForce = 500F;

    // We marked this as "FixedUpdate" because we
    // are using it to mess with PHYSICS
    void FixedUpdate()
    {  
        // Added forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        // Added Player input (Basic)
        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
