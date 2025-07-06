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
            maxhits--;
        }

        if (maxhits == 0)
        {
            SpriteRenderer spriteRenderer = GetComponentInChildren<SpriteRenderer>();
            spriteRenderer.sprite = emptyblock;
        }
    }
}
