using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermomvement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float moveSpeed;

    private RaycastHit2D hit;
    public float jumpForce;
    private bool jumping;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        jumping = false;
    }


    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        rb.AddForce(Vector2.right * horizontal * moveSpeed * Time.deltaTime);

        jump();

        flipDirection();

        changeAnimations();
    }

    private void jump()
    {
        hit = Physics2D.CircleCast(rb.position, 0.5f, Vector2.down, 0.4f, LayerMask.GetMask("Default"));

        if (hit.collider != null && Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
            jumping = true;
            Invoke("resetJumping", 0.18f);
        }

        if (jumping && Input.GetKey(KeyCode.Space))
        {
            Vector3 velocity = rb.velocity;
            velocity.y = jumpForce;
            rb.velocity = velocity;
        }
    }

    private void resetJumping()
    {
        jumping = false;
    }

    private void flipDirection()
    {
        foreach (SpriteRenderer sprite in GetComponentsInChildren<SpriteRenderer>())
        {
            sprite.flipX = rb.velocity.x < 0;
        }
    }

    private void changeAnimations()
    {
        foreach (Animator animator in GetComponentsInChildren<Animator>())
        {
            animator.SetFloat("velocityX", rb.velocity.x);
            animator.SetFloat("horizontalInput", Input.GetAxis("Horizontal"));
            animator.SetBool("inAir", hit.collider == null || jumping);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float distance = 0.375f;

        if (GetComponent<playerbehaviour>().big)
        {
            distance += 1f;
        }

        RaycastHit2D hitTop = Physics2D.CircleCast(rb.position, 0.25f, Vector2.up, distance, LayerMask.GetMask("Default"));

        if (hitTop.collider != null)
        {
            Vector3 velocity = rb.velocity;
            velocity.y = 0;
            rb.velocity = velocity;
            jumping = false;

            blockhit blockHit = hitTop.collider.gameObject.GetComponent<blockhit>();
            if (blockHit != null)
            {
                blockHit.hit();
            }
        }
    }
}