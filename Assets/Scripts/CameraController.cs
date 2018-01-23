﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour 
{
	public GameObject player;

	Vector3 offset;

	void Awake()
	{
		offset = transform.position - player.transform.position;
	}

	void LateUpdate () 
	{
		transform.position = player.transform.position + offset;
	}
}
