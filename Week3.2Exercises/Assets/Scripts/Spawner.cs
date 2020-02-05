using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    float elapsedTime;
    float eventTime;

    public GameObject objectToBeSpawned;

    void Start ()
    {
		
	}
	
	void Update ()
    {
        elapsedTime += Time.deltaTime;

        //if elapsed time is greater than or equal to event time, play the audio
        if (elapsedTime >= eventTime)
        {
            Instantiate(objectToBeSpawned, transform.position, Quaternion.identity);

            //reset timer
            elapsedTime = 0;

            eventTime = Random.Range(2, 5);//random time between 2 and 5 seconds
        }
    }
}
