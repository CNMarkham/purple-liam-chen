using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghost : movement
{
    public GameObject body;
    public GameObject eyes;
    public GameObject blue;
    public GameObject white;
    public bool atHome;
    public float homeDuration;
    private bool frightned;

    private void Awake()
    {
        // set the original state of the ghost
    }

    protected override void childUpdate()
    {
        // umm... nothing!
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // see if ghost hits pacman or home wall
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // check is ghost hits a node, change directions
        Node node = collision.GetComponent<Node>();

        if (node != null)
        {
            int index = Random.Range(0, node.availableDriections.Count);

            if (node.availableDriections[index] == -direction)
            {
                index += 1;
            }

            setDirection(node.availableDriections[index]);
        }

    }

    private void leaveHome()
    {
        // switch from home mode to scatter mode
    }

    public void frighten()
    {
        // set ghost to frightened if not at home
    }

    private void flash()
    {
        // make ghost flash white
    }

    private void Reset()
    {
        // turns ghost back to normal
    }
}
