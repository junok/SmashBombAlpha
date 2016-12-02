using UnityEngine;
using System.Collections;
using System;

public class PowerUpSpawn : MonoBehaviour {

    public int startTime = 3;
    public int endTime = 10;
    public int powerUpType;
    public GameObject powerUp;
    public bool randomOrNot = true;

    private float time;
    private float spawnTimer;
	// Use this for initialization
	void Start () {
        time = 0;   
	}

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

        //Counts up
        time += Time.deltaTime;

        //Check if its the right time to spawn the object
        if (time >= spawnTimer)
        {
            powerUpType = GetRandomNumber(1, 4);
            InstantiatePowerUp();
            spawnTimer = GetRandomNumber(startTime, endTime);
        }

    }

    void InstantiatePowerUp()
    {
        time = 0;
        powerUp.GetComponent<ChangePowerUps>().powerUpMode = powerUpType;
        Instantiate(powerUp, this.gameObject.transform.position, Quaternion.identity);
    }


    private static readonly System.Random getrandom = new System.Random();
    private static readonly object syncLock = new object();
    public static int GetRandomNumber(int min, int max)
    {
        lock (syncLock)
        { // synchronize
            return getrandom.Next(min, max);
        }
    }
}
