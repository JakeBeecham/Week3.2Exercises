using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    AudioSource audioSource;

	void Start ()
    {
        audioSource = GetComponent<AudioSource>();
	}
	
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.P) && audioSource.isPlaying)
        {
            //if P is pressed and the audio is playing
            audioSource.Pause();
            //add message to the console window in Unity
            Debug.Log("Paused");
        }
        else if(Input.GetKeyDown(KeyCode.P) && !audioSource.isPlaying)
        {
            //if P is pressed and the audio is not playing
            audioSource.Play();
            //add message to the console window in Unity
            Debug.Log("Playing");
        }
        else if(Input.GetKeyDown(KeyCode.S))
        {
            //if S is pressed stop the audio
            audioSource.Stop();
            //add message to the console window in Unity
            Debug.Log("Stopped");
        }
	}
}
