﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimObstacle : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        anim.SetBool("Move",true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
