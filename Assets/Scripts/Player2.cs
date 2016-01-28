using UnityEngine;
using System.Collections;

public class Player2 : MonoBehaviour
{
    public GameObject ball;
    public ParticleSystem collision;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 destination = new Vector3(5.44f, 0, ball.transform.position.z);
        transform.position = Vector3.Slerp(transform.position, destination, 0.008f);
    }
    
    void OnCollisionEnter(Collision other)
    {
        collision.Play();
    }
}