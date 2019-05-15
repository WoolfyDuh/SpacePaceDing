using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{
   
    [SerializeField]
    private float speed = 0.5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Destroy(this.gameObject, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up*speed);
        //transform.position = Vector2.MoveTowards(transform.position, transform.position, speed * Time.deltaTime);

        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreLayerCollision(8, 9);
    }
}
