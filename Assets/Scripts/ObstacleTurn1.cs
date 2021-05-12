using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTurn1 : MonoBehaviour
{   
    public float speed;
    public bool MoveUp;

    void Start()
    {
        
    }

    
    void Update()
    {
        if (MoveUp)
        {
            transform.Translate(0, 2 * Time.deltaTime * speed, 0);
        }
        else
        {
            transform.Translate(0, -2 * Time.deltaTime * speed, 0);
        }
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
