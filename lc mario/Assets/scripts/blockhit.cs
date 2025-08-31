using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockhit : MonoBehaviour
{
    public GameObject item;
    public int maxhits = -1;
    public Sprite emptyblock;
    private Animator animator;

    void Start()
    {
        animator = GetComponentInChildren<Animator>();
    }

    public void hit()
    {
        if (maxhits <= 0)
        {
            return;
        }

        if (item != null)
        {
            Instantiate(item, transform);
            animator.SetTrigger("hit");
            Invoke("ForceDynamic", 0.4f);
            maxhits--;
            
        }

        if (maxhits == 0)
        {
            SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            spriteRenderer.sprite = emptyblock;
        }
    }

    public void ForceDynamic()
    {
        // tacky solution; make the mushroom turn dynamic
        Rigidbody2D RB = GetComponentInChildren<Rigidbody2D>();
        if (RB != null)
        {
            RB.bodyType = RigidbodyType2D.Dynamic;
        }
    }
}
