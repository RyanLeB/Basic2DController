using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    public Animator anim;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
        movement.y = Input.GetAxis("Vertical");
        anim.SetFloat("Horizontal", Input.GetAxis("Horizontal"));
        anim.SetFloat("Vertical", Input.GetAxis("Vertical"));

    }

    void FixedUpdate()
    {
        
        rb.velocity = new Vector2(movement.x * moveSpeed, movement.y * moveSpeed);

    }



}
