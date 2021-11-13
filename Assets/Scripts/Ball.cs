using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed= 10;
    void Start()
    {
        GetComponent<Rigidbody2D>().velocity= Vector2.up*speed;
    }

    float hitFactor(Vector2 ballPos, Vector2 racketPos, float racketwidth){
    //ascii art
    //
    // 1  -0.5  0  0.5  1 <- x value 
    // ================== <- racket
    //
    return (ballPos.x - racketPos.x) / racketwidth;
    }
    
    void OnCollisionEnter2D(Collision2D col){
        // Hit the racket?
        if (col.gameObject.name == "racket"){
            //calculate hit factor
            float x = hitFactor(transform.position, col.transform.position, col.collider.bounds.size.x);

            //calculate direction, set length to 1
            Vector2 dir = new Vector2(x, 1).normalized;

            // Set Velocity with dir * spped 
            GetComponent<Rigidbody2D>().velocity = dir * speed;
        }
    }
}
