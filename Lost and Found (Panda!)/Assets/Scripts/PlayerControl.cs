using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public Rigidbody2D Player_rb;

    public float Walk_Speed;
    public float Jump_Speed;

    private bool On_Ground;
    
    void Update()
    {
		SpeedBasedMovement();
    }
    
	void SpeedBasedMovement()
    {
		if (Input.GetKey(KeyCode.D) && On_Ground == true)
		{
			Player_rb.velocity = new Vector2 (Walk_Speed, Player_rb.velocity.y);
		}
		if (Input.GetKey(KeyCode.A) && On_Ground == true)
		{
            Player_rb.velocity = new Vector2(-Walk_Speed, Player_rb.velocity.y);
        }
        if (Input.GetKey(KeyCode.W) && On_Ground == true)
		{
            Player_rb.velocity = new Vector2(Player_rb.velocity.x, Jump_Speed);
        }
	}

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            On_Ground = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        On_Ground = false;
    }
}
