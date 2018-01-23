using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObject : MonoBehaviour 
{
	public GameObject[] prefabObjects;
	public Transform[] spawnPositions;



	void Start()
	{
		Instantiate (prefabObjects [0], spawnPositions[0].position,transform.rotation);
		Instantiate (prefabObjects [1], spawnPositions[1].position,transform.rotation);	
		Instantiate (prefabObjects [0], spawnPositions[2].position,transform.rotation);	
		Instantiate (prefabObjects [1], spawnPositions[3].position,transform.rotation);	
	}

	void Update()
	{
		
	}

}
