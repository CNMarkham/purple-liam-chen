using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscript : MonoBehaviour
{
    public float speed;
    private Animator animator;
    static private Vector2 direction;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        direction = Vector2.right;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetTrigger("dies");
        Destroy(gameObject, 0.25f);
        Destroy(collision.gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);

        if (transform.position.x > 8f)
        {
            direction = Vector2.left;
            movedown();
        }

        if (transform.position.x < -8f)
        {
            direction = Vector2.right;
            movedown();
        }
    }

    private void movedown()
    {
        foreach (enemyscript enemy in FindObjectsOfType(typeof(enemyscript)))
        {
            enemy.transform.Translate(Vector2.down);
        }
    }
}