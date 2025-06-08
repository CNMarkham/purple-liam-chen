using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerbehaviour : MonoBehaviour
{
    public SpriteRenderer smallRenderer;
    public SpriteRenderer bigRenderer;
    private Animator smallanimator;
    public bool big;

    private void Start()
    {
        smallanimator = smallRenderer.gameObject.GetComponent<Animator>();
        big = false;
    }

    public void hit()
    {
        if (big)
        {
            shrink();
        } else
        {
            death();
        }
    }

    private void shrink()
    {
        smallRenderer.enabled = true;
        bigRenderer.enabled = false;

        GetComponent<CapsuleCollider2D>().size = Vector2.one;
        GetComponent<CapsuleCollider2D>().offset = Vector2.zero;

        big = false;
        StartCoroutine("changesize");
    }

    public void grow()
    {
        if (big)
        {
            return;
        }
        smallRenderer.enabled = false;
        bigRenderer.enabled = true;

        GetComponent<CapsuleCollider2D>().size = new Vector2(1f, 2f);
        GetComponent<CapsuleCollider2D>().offset = new Vector2(0, 0.5f);

        big = true;
        StartCoroutine("changesize");
    }

    private void death()
    {
        smallanimator.SetTrigger("death");

        GetComponent<CapsuleCollider2D>().enabled = false;

        GetComponent<Rigidbody2D>().velocity = Vector2.up * 10;
        GetComponent<playermomvement>().enabled = false;
        Destroy(gameObject, 1f);
    }

    private IEnumerator changesize()
    {
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        Vector3 velocity = rb.velocity;
        GetComponent<playermomvement>().enabled = false;
        GetComponent<CapsuleCollider2D>().enabled = false;
        rb.isKinematic = true;
        rb.velocity = Vector3.zero;

        for (int i = 0; i < 8; i++)
        {
            bigRenderer.enabled ^= true;
            smallRenderer.enabled ^= true;
            yield return new WaitForSeconds(0.25f);
        }

        rb.isKinematic = false;
        rb.velocity = velocity;
        GetComponent<playermomvement>().enabled = true;
        GetComponent<CapsuleCollider2D>().enabled = true;
    }
}
