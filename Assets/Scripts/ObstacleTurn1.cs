using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTurn1 : MonoBehaviour
{   
    public float speed;
    public bool MoveUp;
    public Rigidbody2D rb;
    public float yVelocity;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
    
        float speed = 10; 

        if (MoveUp)
        {
            yVelocity=speed;
        }
        else
        {
            yVelocity=-speed;
        }
        rb.velocity = new Vector2(0, yVelocity);
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
    }
}
