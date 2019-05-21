using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ASSteroidSpawnScript : MonoBehaviour
{
	 //position = Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10));
	public GameObject asteroid;
	Vector3 position;
	// Start is called before the first frame update
	void Start()
	{
		position = new Vector3(Random.Range(1, 100), 0, Random.Range(2,100));
	}

	// Update is called once per frame
	void FixedUpdate()
	{
		if (Input.GetKeyUp(KeyCode.Return))
		{
			Instantiate(asteroid,position, Quaternion.identity);
		}
	}
}

