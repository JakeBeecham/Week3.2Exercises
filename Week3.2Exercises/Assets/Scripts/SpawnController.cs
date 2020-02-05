using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    BoxCollider2D spawnArea;

    Vector3 randomPosition;

    public GameObject objectToSpawn;

	void Start ()
    {
        spawnArea = GetComponent<BoxCollider2D>();
	}
	
    //returns a Vector 3 to the caller of the method
    Vector3 PickRandomPosition()
    {
        //bounds.min is the leftmost position of the box
        //bounds.max is the rightmost position of the box
        float x = Random.Range(spawnArea.bounds.min.x, spawnArea.bounds.max.x);
        float y = Random.Range(spawnArea.bounds.min.y, spawnArea.bounds.max.y);

        return new Vector3(x, y, 0);
    }

	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            randomPosition = PickRandomPosition();
            //clone the objectToSpawn and position it at the random position
            Instantiate(objectToSpawn, randomPosition, Quaternion.identity);
        }
	}
}
