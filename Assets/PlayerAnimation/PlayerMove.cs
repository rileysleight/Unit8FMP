using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Animator anim;
    private Rigidbody2D rb;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
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
            anim.SetBool("WalkLeft",true);
            xVelocity =-speed;
        }
        else
        {
            anim.SetBool("WalkLeft", false);
            anim.SetBool("Idle",true);
        }


        if (Input.GetKey(KeyCode.RightArrow))
        {
;           anim.SetBool("WalkRight",true);
            xVelocity=speed;
        }
        else
        {
            anim.SetBool("WalkRight",false);
            anim.SetBool("Idle",true);
        }


        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("WalkUp",true);
            yVelocity=speed;
        }
        else
        {
            anim.SetBool("WalkUp",false);
            anim.SetBool("Idle",true);
        }


        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("WalkDown",true);
            yVelocity=-speed;
        }
        else
        {
            anim.SetBool("WalkDown",false);
            anim.SetBool("Idle",true);
        }


        rb.velocity = new Vector2(xVelocity, yVelocity);
    }
}
