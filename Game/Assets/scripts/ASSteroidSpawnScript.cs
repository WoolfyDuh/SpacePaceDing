﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASSteroidSpawnScript : MonoBehaviour
{
	public GameObject asteroid;

	// Start is called before the first frame update
	void Start()
	{

	}

	// Update is called once per frame
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Return))
		{
			Instantiate(asteroid);
		}
	}
}
