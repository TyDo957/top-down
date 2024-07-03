using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMove : MonoBehaviour
{
    
     [SerializeField] private float speed = 10f;
     private Rigidbody2D rb;
     public Vector3 moveInput;
     public Animator animator;
     public SpriteRenderer spriteRenderer;

     private bool isFacingRight = true; // Track player's facing direction

     void Start()
     {
         rb = GetComponent<Rigidbody2D>();
         animator = GetComponent<Animator>();
     }

     void Update()
     {
         moveInput.x = Input.GetAxis("Horizontal");
         moveInput.y = Input.GetAxis("Vertical");

         // Update animator with movement speed for animation control
         animator.SetFloat("Speed", moveInput.sqrMagnitude);
     }

     void FixedUpdate()
     {
         rb.MovePosition(transform.position + moveInput * speed * Time.deltaTime);

         // Determine flip direction based on horizontal input
         bool shouldFlip = moveInput.x != 0 && (moveInput.x > 0 && !isFacingRight || moveInput.x < 0 && isFacingRight);

         // Flip sprite renderer if necessary
         if (shouldFlip)
         {
             isFacingRight = !isFacingRight;
             spriteRenderer.flipX = !isFacingRight;
         }
     }
    
}



