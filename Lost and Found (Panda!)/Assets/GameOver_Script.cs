﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Script : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Game Over!");
        }
    }
}
