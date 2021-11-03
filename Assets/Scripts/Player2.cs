using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Cinemachine; 

public class Player2 : MonoBehaviour
{
    //private Animator anim;
    private Rigidbody2D rb;
    public float speed;
    public GameObject dialougue1;
    public int lives = 5;
    public GameObject Block;
    public GameObject puzzle2;
    public GameObject Life1;
    public GameObject Life2;
    public GameObject Life3;
    public GameObject Life4;
    public GameObject Life5;
    public GameObject hud;
    public GameObject pause;
    private Animator anim;


    

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
    
        if (lives == 4)
        {
            Life1.SetActive(false);
        }
        else if (lives == 3)
        {
            Life2.SetActive(false);
        }
        else if (lives == 2)
        {
            Life3.SetActive(false);
        }
        else if (lives == 1)
        {
            Life4.SetActive(false);
        }
        else if (lives == 0)
        {
            Life5.SetActive(false);
            Debug.Log("Dead");
            SceneManager.LoadScene(1);
        }
        else
        {

        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            anim.SetBool("WalkLeft",true);
            xVelocity =-speed;
        }
        else
        {
            anim.SetBool("WalkLeft", false);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("WalkRight", true);
            xVelocity=speed;
        }
        else
        {
            anim.SetBool("WalkRight", false);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            anim.SetBool("WalkUp", true);
            yVelocity=speed;
        }
        else
        {
           anim.SetBool("WalkUp", false);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            anim.SetBool("WalkDown", true);
            yVelocity=-speed;
        }
        else
        {
            anim.SetBool("WalkDown", false);
        }
        

        if ((xVelocity == 0) && (yVelocity == 0))
        {
            anim.SetBool("WalkDown", false);
            anim.SetBool("WalkUp", false);
            anim.SetBool("WalkLeft", false);
            anim.SetBool("WalkRight", false);
        }

        rb.velocity = new Vector2(xVelocity, yVelocity);
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pause.SetActive(true);
            hud.SetActive(false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacle2"))
        {
            LoseLife();
            transform.position = new Vector2(35, 0);
        }

        if(other.CompareTag("Telly1"))
        {
            dialougue1.SetActive(true);
        }

        if(other.CompareTag("Puzzle2"))
        {
            Debug.Log("Help");
            hud.SetActive(false);
            puzzle2.SetActive(true);
        }

        if(other.CompareTag("LDoor"))
        {
            if(gameObject.tag == "PlayerKey")
            {
                SceneManager.LoadScene (4);
            }
            
        }
        if(other.CompareTag("RDoor"))
        {
            if(gameObject.tag == "PlayerKey")
            {
                SceneManager.LoadScene (5);
            }
            
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
        hud.SetActive(true);
    }

    public void CorrectChoice()
    {
        Debug.Log("Right");
        Destroy(Block);
        transform.position = new Vector2(88, 0);
        hud.SetActive(true);
    }

       
   public void QuitToMenu (string Menu) 
   {
      SceneManager.LoadScene(0);
   }

   public void ResumeGame()
   {
      pause.SetActive(false);
      hud.SetActive(true);
   }
}