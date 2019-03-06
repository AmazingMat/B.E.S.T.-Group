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
    private float X_PlayerSpeed;

    public Rigidbody2D Player_rb;
    public Rigidbody2D Camera_rb;
    
    void Update()
    {
        X_Distance = Player.GetComponent<Transform>().position.x - MainCam.GetComponent<Transform>().position.x;
        CameraMovement();
        Debug.Log(Camera_rb.velocity.x);
    }

    void CameraMovement()
    {
        X_PlayerSpeed = Player_rb.velocity.x;

        if (X_Distance > 8 && X_PlayerSpeed > 0)
        {
            Right = true;
            Camera_rb.velocity = new Vector2(X_PlayerSpeed, 0);
            
        }
        if (X_Distance < -8 && X_PlayerSpeed < 0)
        {
            Left = true;
            Camera_rb.velocity = new Vector2(X_PlayerSpeed, 0);
            
        }
        if (X_Distance > 8 || X_Distance < -8)
        {
            Dis_Check = true;
        }
        if (X_Distance < 8 && X_Distance > -8)
        {
            Camera_rb.velocity = new Vector2(0, 0);
            Left  = false;
            Right = false;
            Dis_Check = false;
        }
    }
}
