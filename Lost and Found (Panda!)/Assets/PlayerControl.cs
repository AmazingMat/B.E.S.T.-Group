using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public Rigidbody2D Player_rb;
	public float Walk_Speed;
	public float Jump_Speed;

    void FixedUpdate()
    {
		SpeedBasedMovement();
    }

	void SpeedBasedMovement(){

		if (Input.GetKeyDown(KeyCode.D))
		{
			Player_rb.velocity.x = 3;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			Player_rb.velocity.x = -3;
		}
		if (Input.GetKeyDown(KeyDown.W))
		{
			Player_rb.velocity.y = 3;
		}
	}
}
