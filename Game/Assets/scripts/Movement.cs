﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private int Lives;
    public float XVelocity;
    float YVelocity;
    Vector2 HeldVelocity;
    Rigidbody2D r2d2;
    private Vector2 spawnpos;
    // Start is called before the first frame update
    void Start()
    {
        spawnpos = transform.position;
        Lives = 3;	   //DIT IS ONZE LEVENS BOI
        XVelocity = 10; //DIT IS ONZE ROTATION BOI
        YVelocity = 7; //DIT IS ONZE MOVEMENT BOI
        r2d2 = GetComponent<Rigidbody2D>(); //DIT IS ONZE RIGIDBOI
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        //MOVEMENT forward
        if (Input.GetKey("w"))
        {
            r2d2.AddForce(transform.up * (YVelocity * 50) * Time.deltaTime);
            HeldVelocity = r2d2.velocity;
        }
        if (Input.GetKey("s"))
        {//MOVEMENT BACKWARD
            r2d2.AddForce(transform.up * -(YVelocity * 50) * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        { //MOVEMENT LEFT
            transform.Rotate(Vector3.forward * -(YVelocity * 3) * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {   //MOVEMENT RIGHTO
            transform.Rotate(Vector3.forward * (YVelocity * 3) * Time.deltaTime);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        { //DIT HOORT DE SHIT TE STOPPEN ALS DIE EEN ENEMY AANRACKT
            r2d2.velocity = Vector3.zero;
            if (Lives > 0)
            {
                Lives--;
                Debug.Log(Lives);
            }
            else
            {
                Reset();
            }
        }
    }
    private void Reset()
    {
        transform.position = spawnpos;
    }
}