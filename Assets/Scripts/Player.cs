using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine; 

public class Player : MonoBehaviour
{
    //private Animator anim;
    private Rigidbody2D rb;
    public float speed;
    public GameObject dialougue1;
    public GameObject puzzle1;
    public int lives = 5;
    public GameObject Block;
    public GameObject puzzle2;
    

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
    

        if (lives == 0)
        {
            Debug.Log("Dead");
            SceneManager.LoadScene(1);
        }
        
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

    void OnTriggerEnter2D(Collider2D other)
    {
        //LEVEL 1
        if(other.CompareTag("Obstacle"))
        {
            LoseLife();
            transform.position = new Vector2(35, 0);
        }

        if(other.CompareTag("Telly1"))
        {
            dialougue1.SetActive(true);
        }

        if(other.CompareTag("Puzzle1"))
        {
            Debug.Log("Help");
            puzzle1.SetActive(true);
        }

        if(other.CompareTag("Key"))
        {
            gameObject.tag = "PlayerKey";
            Destroy(other.gameObject);
        }

        if(other.CompareTag("Door"))
        {
            if(gameObject.tag == "PlayerKey")
            {
                SceneManager.LoadScene (2);
            }
            
        }

        //LEVEL 2
        if(other.CompareTag("Obstacle2"))
        {
            LoseLife();
            transform.position = new Vector2(35, 0);
        }
        
        if(other.CompareTag("Puzzle2"))
        {
            puzzle2.SetActive(true);
        }
    }

    public int LoseLife()
    {
        lives--;
        return lives;
    }


    public void IncorrectChoice()
    {
        LoseLife();
        Debug.Log("Wrong");
        transform.position = new Vector2(84, 0);
    }

    public void CorrectChoice()
    {
        Debug.Log("Right");
        Destroy(Block);
        transform.position = new Vector2(88, 0);
    }

}