using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour
{

    public Rigidbody2D bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //Als spacebar is ingedrukt
        {
            BulletAttack();
        }

    }


    void BulletAttack()
    {
        Rigidbody2D bPrefab = Instantiate(bulletPrefab, transform.position, Quaternion.identity) as Rigidbody2D; //Maakt nieuwe bullet van bulletPrefab, quaternion.identity = geen rotatie, is perfect gelijk aan de wereld

        bPrefab.AddForce(Vector2.right * 500); //Zet snelheid naar rechts naar 500
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {


        Physics2D.IgnoreLayerCollision(8, 9);
    }
}
