using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
	public Rigidbody2D Player_rb;
	public Vector2 Walk_Speed;
	public Vector2 Jump_Speed;

    void FixedUpdate()
    {
		SpeedBasedMovement();
    }

	void SpeedBasedMovement(){

		if (Input.GetKeyDown(KeyCode.D))
		{
			Player_rb.velocity = Walk_Speed;
		}
		if (Input.GetKeyDown(KeyCode.A))
		{
			Player_rb.velocity = -Walk_Speed;
		}
		if (Input.GetKeyDown(KeyCode.W))
		{
			Player_rb.velocity = Jump_Speed;
		}
	}
}
