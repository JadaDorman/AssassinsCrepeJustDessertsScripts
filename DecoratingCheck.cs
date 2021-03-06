﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecoratingCheck : MonoBehaviour

{
    public string itemName;
    private bool playerInBounds;
    private bool once = false;
    public static bool success;
    private static double gameScore = 0;
    void OnTriggerStay2D(Collider2D decor)
    {

       if (decor.gameObject.name == itemName)
       {
            playerInBounds = true;
            once = true;

       }
    }

    void OnTriggerExit2D(Collider2D decor)
    {
        if (decor.gameObject.name == itemName)
        {
            playerInBounds = false;
        }
    }

    void Start()
    {
        gameScore = 0;
        success = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonUp(0) && playerInBounds && once /*&& gameScore <=7*/)
        {
            gameScore++;
            once = false;
            Debug.Log(gameScore);
        }
        Success();
    }

    void Success()
    {     
            if (gameScore > 5)
            {
                success = true;
                gameScore = 0;
            //PoisonScoreCount.minigameScore++;
            //Debug.Log(PoisonScoreCount.minigameScore);
            }
      
    }
}
