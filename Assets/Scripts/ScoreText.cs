using UnityEngine;
using System.Collections;

public class ScoreText : MonoBehaviour
{

    public GameObject ball;
    public GameObject ball2;
    private float player1score;
    private float player2score;
    public bool GameOver = false;


    // Use this for initialization
    void Start ()
    {
        player1score = 0;
        player2score = 0;
    }
	
	// Update is called once per frame
	void Update ()
    {
        GetComponent<TextMesh>().text = player1score.ToString() + "||" + player2score.ToString();

        if(ball.transform.position.x > 5.44)
        {
            player1score++;
            ball.transform.position = new Vector3(-0.03f, 0, 4.32f);
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 200 + Vector3.forward * 100);
        }

        if (ball.transform.position.x < -5.44)
        {
            player2score++;
            ball.transform.position = new Vector3(-0.03f, 0, 4.32f);
            ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
            ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 200 + Vector3.forward * 100);
        }

        if (player1score >= 5)
        {
            ball2.SetActive(true);
            if (ball2.transform.position.x > 5.44)
            {
                player1score++;
                ball2.transform.position = new Vector3(-0.03f, 0, 4.32f);
                ball2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                ball2.GetComponent<Rigidbody>().AddForce(Vector3.right * 200 + Vector3.forward * 100);
            }

            if (ball2.transform.position.x < -5.44)
            {
                player2score++;
                ball2.transform.position = new Vector3(-0.03f, 0, 4.32f);
                ball2.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                ball2.GetComponent<Rigidbody>().AddForce(Vector3.right * 200 + Vector3.forward * 100);
            }
        }

        else if (player1score == 10 || player2score == 10)
        {
            GameOver = true;
            GUI.Label(new Rect(0, 0, 100, 20), "Game Over!");
            Time.timeScale = 0;
        }
    }
}
