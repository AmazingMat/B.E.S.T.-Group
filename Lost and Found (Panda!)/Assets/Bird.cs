using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    public float min_height;
    public float max_height;
    public float min_left;
    public float max_right;

    public float Y_Speed;
    public float X_Speed;

    public Rigidbody2D Bird_rb;

    private void Start()
    {
        Bird_rb.velocity = new Vector2(X_Speed, Y_Speed);
    }
    void Update()
    {
        BirdMovement_Y();
        BirdMovement_X();
        Debug.Log(transform.position.x);
    }

    void BirdMovement_Y()
    {
        if (Y_Speed != 0)
        {
            if (transform.position.y < min_height && Bird_rb.velocity.y < 0)
            {
                Bird_rb.velocity = new Vector2(0, Y_Speed);
            }
            else if (transform.position.y > max_height && Bird_rb.velocity.y > 0)
            {
                Bird_rb.velocity = new Vector2(0, -Y_Speed);
            }
        } 
    }

    void BirdMovement_X()
    {
        if (X_Speed != 0)
        {
            if (transform.position.x > max_right && Bird_rb.velocity.x > 0)
            {
                Bird_rb.velocity = new Vector2(-X_Speed, Y_Speed);
                
            }
            if (transform.position.x < min_left && Bird_rb.velocity.x < 0)
            {
                Bird_rb.velocity = new Vector2(X_Speed, Y_Speed);
                
            }
        } 
    }
}