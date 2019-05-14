using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	public float XVelocity;
	public float YVelocity;
    // Start is called before the first frame update
    void Start()
    {
		XVelocity = 5;
		YVelocity = 5;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	private void FixedUpdate()
	{
		if (Input.GetKey("W"))
		{
			transform.Translate(Vector3.up * (YVelocity + 10) * Time.deltaTime);
		}
	}
}
