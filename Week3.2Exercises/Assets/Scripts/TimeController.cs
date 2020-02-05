using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeController : MonoBehaviour
{
    //store the amount of time passed
    //only public so you can see the values change when testing
    public float elapsedTime;

    //the number of seconds to pass before doing something
    public float eventTime = 2;

    AudioSource audioSource;

    void Start ()
    {
        audioSource = GetComponent<AudioSource>();
    }
	
	void Update ()
    {
        elapsedTime += Time.deltaTime;

        //if elapsed time is greater than or equal to event time, play the audio
        if(elapsedTime >= eventTime)
        {
            //play audio
            audioSource.Play();
            //add message to the console window in Unity
            Debug.Log("Play!");

            //reset timer
            elapsedTime = 0;

            //pick a ransom event time every reset
            eventTime = Random.Range(2, 5);//random time between 2 and 5 seconds
        }
	}
}
