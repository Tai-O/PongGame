using UnityEngine;
using System.Collections;

public class BallHandler : MonoBehaviour
{
    public Rigidbody myrigidbody;

    // Use this for initialization
    void Start ()
    {
        this.myrigidbody = this.GetComponent<Rigidbody>();
        myrigidbody.AddForce(Vector3.right * 200 + Vector3.forward * 100);
    }
	
	// Update is called once per frame
	void Update ()
    {
	    if (Mathf.Abs (myrigidbody.velocity.x) < 40)
        {
            Vector3 shrt = myrigidbody.velocity;
            myrigidbody.velocity = new Vector3(shrt.x + 0.001f / Time.deltaTime * Mathf.Sign(shrt.x), shrt.y, shrt.z);
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
	}


    void OnCollisionEnter(Collision other)
    {
        if (Mathf.Abs(myrigidbody.velocity.z) < 5.52)
        {
            Vector3 shrt = myrigidbody.velocity;
            myrigidbody.AddForce(other.relativeVelocity);
            myrigidbody.AddForce(Vector3.forward * 250 * Mathf.Sign(shrt.z));

        }

        else if (Mathf.Abs(myrigidbody.velocity.z) > -2)
        {
            Vector3 shrt = myrigidbody.velocity;
            myrigidbody.AddForce(other.relativeVelocity);
            myrigidbody.AddForce(Vector3.up * 250 * Mathf.Sign(shrt.z));
        }
    }
}
