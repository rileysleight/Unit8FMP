using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //private Animator anim;
    private Rigidbody2D rb;
    public float speed;


    void Start()
    {
        //anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xVelocity = 0;
        float yVelocity = 0;
        float speed = 5; 

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //anim.SetBool("Walk Left",true);
            xVelocity =-speed;
        }
        //else
        //{
        //    anim.SetBool("Walk Left", false);
        //}

        if (Input.GetKey(KeyCode.RightArrow))
        {
            //anim.SetBool("Walk Right", true);
            xVelocity=speed;
        }
        //else
        //{
        //    anim.SetBool("Walk Right", false);
        //}

        if (Input.GetKey(KeyCode.UpArrow))
        {
        //    anim.SetBool("Walk Up", true);
            yVelocity=speed;
        }
        //else
        //{
        //   anim.SetBool("Walk Up", false);
        //}

        if (Input.GetKey(KeyCode.DownArrow))
        {
            //anim.SetBool("Walk Down", true);
            yVelocity=-speed;
        }
        //else
        //{
        //    anim.SetBool("Walk Down", false);
        //}
        

        //if ((xVelocity == 0) && (yVelocity == 0))
        //{
        //    anim.SetBool("Walk Down", false);
        //    anim.SetBool("Walk Up", false);
        //    anim.SetBool("Walk Left", false);
        //    anim.SetBool("Walk Right", false);
        //}

        rb.velocity = new Vector2(xVelocity, yVelocity);
    }
}