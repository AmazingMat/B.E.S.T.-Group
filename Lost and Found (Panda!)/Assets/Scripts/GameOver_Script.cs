using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Script : MonoBehaviour
{
    public AudioSource GameOverSound;

    private bool Game_Over = false;

    private void Update()
    {
        SoundTrigger();
    }
  
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            Debug.Log("Game Over!");
            Game_Over = true;
        }
    }

    void SoundTrigger()
    {
        if (Game_Over == true)
        {
            GameOverSound.Play();
        }
        Game_Over = false;
    }
}
