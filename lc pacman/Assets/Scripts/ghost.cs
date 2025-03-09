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
    private bool frightened;

    private void Awake()
    {
        // set the original state of the ghost
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
        frightened = false;
        Invoke("leaveHome", homeDuration);
    }

    protected override void childUpdate()
    {
        // umm... nothing!
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // see if ghost hits pacman or home wall
        if (atHome && collision.gameObject.layer == LayerMask.NameToLayer("obstacle"))
        {
            setDirection(-direction);
        }

        if (collision.gameObject.CompareTag("Pacman"))
        {
            if (frightened)
            {
                transform.position = new Vector3(0, -0.5f, -1);
                body.SetActive(false);
                eyes.SetActive(true);
                blue.SetActive(false);
                white.SetActive(false);
                atHome = true;
            }
            else
            {

            }
        }
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

                if (index == node.availableDriections.Count)
                {
                    index = 0;
                }
            }

            setDirection(node.availableDriections[index]);
        }

    }

    private void leaveHome()
    {
        // switch from home mode to scatter mode
        transform.position = new Vector3(0, 2.5f, -1f);
        direction = new Vector2(-1, 0);
        atHome = false;
        frightened = false;
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
    }

    public void frighten()
    {
        // set ghost to frightened if not at home
        if (!atHome)
        {
            frightened = true;
            body.SetActive(false);
            eyes.SetActive(false);
            blue.SetActive(true);
            white.SetActive(false);
            Invoke("flash", 4f);
        }
    }

    private void flash()
    {
        // make ghost flash white
        body.SetActive(false);
        eyes.SetActive(false);
        blue.SetActive(false);
        white.SetActive(true);
        Invoke("reset", 4f);
    }

    private void Reset()
    {
        // turns ghost back to normal
        frightened = false;
        body.SetActive(true);
        eyes.SetActive(true);
        blue.SetActive(false);
        white.SetActive(false);
    }
}
