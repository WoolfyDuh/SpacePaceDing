using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float XVelocity;
	public float YVelocity;
	Rigidbody2D r2d2;
	// Start is called before the first frame update
	void Start()
    {
		XVelocity = 5;
		YVelocity = 5;
		r2d2 = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
		
	}
	private void FixedUpdate()
	{
		if (Input.GetKey("w"))
		{
			r2d2.AddForce(transform.up * YVelocity);
		}
	}
}
