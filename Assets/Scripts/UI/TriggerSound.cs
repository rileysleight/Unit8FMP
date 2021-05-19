﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
 using UnityEngine.EventSystems;

public class TriggerSound : MonoBehaviour, ISelectHandler , IPointerEnterHandler
{
    

    public void OnPointerEnter(PointerEventData eventData)
    {
        //print("entered");
        AudioManager.instance.Play("MenuHover");
    }

    public void OnSelect( BaseEventData eventData )
    {
        //print("selected");
        AudioManager.instance.Play("MenuSelect");
    }
}