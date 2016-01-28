using UnityEngine;
using System.Collections;

public class Ball2Handler : MonoBehaviour
{
    public Rigidbody myrigidbody2;

    // Use this for initialization
    void Start()
    {
        this.myrigidbody2 = this.GetComponent<Rigidbody>();
        myrigidbody2.AddForce(Vector3.left * 200 + Vector3.forward * 100);
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(myrigidbody2.velocity.x) < 40)
        {
            Vector3 shrt = myrigidbody2.velocity;
            myrigidbody2.velocity = new Vector3(shrt.x + 0.001f / Time.deltaTime * Mathf.Sign(shrt.x), shrt.y, shrt.z);
        }
        transform.position = new Vector3(transform.position.x, 0, transform.position.z);
    }


    void OnCollisionEnter(Collision other)
    {
        if (Mathf.Abs(myrigidbody2.velocity.z) < 5.52)
        {
            Vector3 shrt = myrigidbody2.velocity;
            myrigidbody2.AddForce(other.relativeVelocity);
            myrigidbody2.AddForce(Vector3.forward * 250 * Mathf.Sign(shrt.z));

        }

        else if (Mathf.Abs(myrigidbody2.velocity.z) > -2)
        {
            Vector3 shrt = myrigidbody2.velocity;
            myrigidbody2.AddForce(other.relativeVelocity);
            myrigidbody2.AddForce(Vector3.up * 250 * Mathf.Sign(shrt.z));
        }
    }
}
