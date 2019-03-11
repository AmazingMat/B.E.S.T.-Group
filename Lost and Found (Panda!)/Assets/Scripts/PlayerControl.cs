using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public Rigidbody2D Player_rb;

    public float Walk_Speed;
    public float Jump_Speed;

    public AudioSource Jump_Sound;

    private bool On_Ground;
    private bool Player_On = true;

    public Animator animator;

    void Update()
    {
		SpeedBasedMovement();
    }
    
	void SpeedBasedMovement()
    {
        animator.SetFloat("Speed", Player_rb.velocity.x);

        if (Player_On == true)
        {
            if (Input.GetKey(KeyCode.D) && On_Ground == true)
            {
                Player_rb.velocity = new Vector2(Walk_Speed, Player_rb.velocity.y);
            }
            if (Input.GetKey(KeyCode.A) && On_Ground == true)
            {
                Player_rb.velocity = new Vector2(-Walk_Speed, Player_rb.velocity.y);

            }
            if (Input.GetKey(KeyCode.W) && On_Ground == true)
            {
                Player_rb.velocity = new Vector2(Player_rb.velocity.x, Jump_Speed);
                Jump_Sound.Play();
            }
        }
		
	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            On_Ground = true;
        }
        if (collision.collider.tag == "Fall Trigger")
        {
            Player_On = false;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        On_Ground = false;
    }
}
