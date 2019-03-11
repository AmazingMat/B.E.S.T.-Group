using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSettings : MonoBehaviour
{
    public Camera MainCam;

    public GameObject Player;

    public bool Right;
    public bool Left;
    public bool Dis_Check;

    private float X_Distance;
    private float Y_Distance;
    private float X_PlayerSpeed;
    private float Y_PlayerSpeed;

    public Rigidbody2D Player_rb;
    public Rigidbody2D Camera_rb;

    public AudioSource BG_Track;
    
    void Update()
    {
        Y_Distance = Player.GetComponent<Transform>().position.y - MainCam.GetComponent<Transform>().position.y;
        X_Distance = Player.GetComponent<Transform>().position.x - MainCam.GetComponent<Transform>().position.x;
        CameraMovement();
    }

    void CameraMovement()
    {
        X_PlayerSpeed = Player_rb.velocity.x;
        Y_PlayerSpeed = Player_rb.velocity.y;

        if (X_Distance > 3 && X_PlayerSpeed > 0 || X_Distance < -3 && X_PlayerSpeed < 0)
        {
            Camera_rb.velocity = new Vector2(X_PlayerSpeed, 0);
        }
        if (X_Distance < 3 && X_Distance > -3)
        {
            Camera_rb.velocity = new Vector2(0, 0);
        }
        if (transform.position.y >= 7 || Player_rb.position.y > 7)
        {
            if (Y_Distance > 3.5 && Y_PlayerSpeed > 0 || Y_Distance < -13 && Y_PlayerSpeed < 0)
            {
                Camera_rb.velocity = new Vector2(X_PlayerSpeed, Y_PlayerSpeed);
            }
        }
        if (Player_rb.position.y < 7)
        {
            Camera_rb.velocity = new Vector2(Camera_rb.velocity.x, Camera_rb.velocity.y);
            if (transform.position.y < 7)
            {
                Camera_rb.velocity = new Vector2(Camera_rb.velocity.x, 0);
            }
        }
        if (transform.position.x <= 0  && Player.GetComponent<Transform>().position.x <= 0)
        {
            Camera_rb.velocity = new Vector2(0, 0);
        }
    }

    private void Awake()
    {
        BG_Track.Play();
    }
}
