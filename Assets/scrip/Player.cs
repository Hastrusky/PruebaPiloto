using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxSpeed = 300f;
    public float speed = 2f;
    private Rigidbody2D rb2d;
    public Animator anim;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>(); 
    }

    void Update()
    {
        
        anim.SetTrigger("correr");

    }

    void FixedUpdate()
    {
        float h = Input.GetAxis("Horizontal");

        rb2d.AddForce(Vector2.right * speed * h);

        if (rb2d.velocity.x > maxSpeed){
            rb2d.velocity = new Vector2(maxSpeed, rb2d.velocity.y);
        }
        if (rb2d.velocity.x < -maxSpeed){
            rb2d.velocity = new Vector2(-maxSpeed, rb2d.velocity.y);
        }

        Debug.Log(rb2d.velocity.x);
    }
}
