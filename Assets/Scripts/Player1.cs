using UnityEngine;
using System.Collections;

public class Player1 : MonoBehaviour {

    public ParticleSystem collision;

	// Use this for initialization
	void Start ()
    {
	
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if (transform.position.z > 1.33  && Input.GetKey(KeyCode.DownArrow))
        {
            float goup = transform.position.z - 16 * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, 0, goup);
        }

        if ( transform.position.z < 5.52 && Input.GetKey(KeyCode.UpArrow))
        {
            float godown = transform.position.z + 16 * Time.deltaTime;
            transform.position = new Vector3(transform.position.x, 0, godown);
        }
	}

    void OnCollisionEnter(Collision other)
    {
        collision.Play();
    }
}
