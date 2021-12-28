using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f; 
    public float sidewaysForce = 500f;
    public float neowForce = 500f;


    // Start is called before the first frame update


    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")){
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        // jump code that i made
        if(Input.GetKey("w")){
            rb.AddForce(0, neowForce * Time.deltaTime, 0);
        }

        if(Input.GetKey("a")){
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
    }
}
