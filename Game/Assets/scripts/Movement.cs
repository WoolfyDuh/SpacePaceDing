using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
	int Lives;
    public float XVelocity;
    float YVelocity;
	Vector2 HeldVelocity;
    Rigidbody2D r2d2;
    // Start is called before the first frame update
    void Start()
    {
		Lives = 3;
        XVelocity = 5;
        YVelocity = 7;
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
            r2d2.AddForce(transform.up * (YVelocity * 50) * Time.deltaTime);
			HeldVelocity = r2d2.velocity;
			Debug.Log(r2d2.velocity);
        }
        if (Input.GetKey("s"))
        {
            r2d2.AddForce(transform.up * -(YVelocity * 50) * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            transform.Rotate(Vector3.forward * -(YVelocity * 3) * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {
            transform.Rotate(Vector3.forward * (YVelocity * 3) * Time.deltaTime);
        }
    }
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.tag == "enemy")
		{
			r2d2.velocity = Vector3.zero;
			while (Lives > 0)
			{
				Lives--;
				Debug.Log(Lives);
			}
		}
	}
}