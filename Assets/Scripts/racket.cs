using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class racket : MonoBehaviour
{
    //Movement Speed
    public float speed = 150;

    void FixedUpdate()
    {
        //Get Horizontal input 
        float h = Input.GetAxisRaw("Horizontal");

        //Set velocity (movement direction*speed)
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speed;
        
    }
}
