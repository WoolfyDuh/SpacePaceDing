using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour
{
	private Vector3 startPos;
	public GameObject Player;
	private float speed;
    // Start is called before the first frame update
    void Start()
    {
		speed = 50;
		startPos = transform.position;
		if (!Player)
		{
			Player = GameObject.Find("Player");
		}
    }

    // Update is called once per frame
    void Update()
    {
		transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }
	public void OnCollisionEnter(Collision collision)
	{
		
		if (collision.gameObject.name == "Player")
		{

			transform.position = startPos;
		}
	}
}
