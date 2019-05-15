    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
    public Transform firepointR;
    public float speed = 100;
    public Rigidbody2D rb;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Oh well");
            Shoot();
        }

    }
    private void FixedUpdate()
    {
        rb.velocity = -(transform.right * speed);
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepointR.position, firepointR.rotation);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        Physics2D.IgnoreLayerCollision(8, 9);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);
    }
}
