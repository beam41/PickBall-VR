using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {
    public GameObject[] balls;
    public GameObject[] spawnPosition;
    public int ballsNumbers;
    public static int ballCouter;
    int randomInt;
    int randomPos;
	// Use this for initialization
	void Start () {
        ballCouter = 0;
	}
	
	// Update is called once per frame
	void Update () {
        while (ballCouter != ballsNumbers)
        {
            randomBall();
            ballCouter += 1;
            //Debug.Log(ballCouter);

        }
        
    }
    void randomBall()
    {
        randomInt = Random.Range(0, balls.Length);
        randomPos = Random.Range(0, spawnPosition.Length);
        Instantiate(balls[randomInt], spawnPosition[randomPos].transform.position, spawnPosition[randomPos].transform.rotation);

    }
}
