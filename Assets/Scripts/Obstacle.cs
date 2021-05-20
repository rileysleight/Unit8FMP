using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{   
    public float speed;
    public bool MoveUp;
    public bool MoveRight;
    public Rigidbody2D rb;
    public float yVelocity;
    public float xVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
    
        //float speed = 10; 

        if (MoveUp)
        {
            yVelocity=speed;
        }
        else
        {
            yVelocity=-speed;
        }

        if (MoveRight)
        {
            xVelocity = speed;
        }
        else{
            xVelocity = -speed;
        }
        rb.velocity = new Vector2(xVelocity, yVelocity);
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if (trig.gameObject.CompareTag("Turn"))
        {
            if (MoveUp)
            {
                MoveUp = false;
            }
            else
            {
                MoveUp = true;
            }
        }

        if (trig.gameObject.CompareTag("Turn2"))
        {
            if(MoveRight)
            {
                MoveRight = false;
            }
            else
            {
                MoveRight = true;
            }
        }
    }
}
