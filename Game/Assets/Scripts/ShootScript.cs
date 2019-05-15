using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour
{
    private bool allowfire;
    public GameObject bulletPrefab;

    private void Start()
    {
        allowfire = true;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyUp(KeyCode.Space) && allowfire) //Als spatiebalk is ingedrukt
        {
            BulletAttack();
        }
    }

    IEnumerator BulletAttack()
    {
        allowfire = false;
        GameObject bPrefab = Object.Instantiate(bulletPrefab, transform.position, Quaternion.identity) as GameObject; //Maakt nieuwe bullet van bulletPrefab, quaternion.identity = geen rotatie, is perfect gelijk aan de wereld
        yield return new WaitForSeconds(1);
        allowfire = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Physics2D.IgnoreLayerCollision(8, 9);
    }
}