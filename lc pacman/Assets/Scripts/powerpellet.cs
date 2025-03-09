using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerpellet : pellet
{
    protected override void eat()
    {
        base.eat();

        GameObject[] ghosts = GameObject.FindGameObjectsWithTag("Ghost");

        foreach(GameObject ghost in ghosts)
        {
            ghost.GetComponent<ghost>().frighten();
        }
    }
}
