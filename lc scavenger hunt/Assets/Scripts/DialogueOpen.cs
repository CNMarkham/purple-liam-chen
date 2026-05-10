using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueOpen : MonoBehaviour
{

    public string dialogue;
    public GameObject interfaceManager;
    public PlayerHolding pHolding;
    public bool begin = true;
    public bool end = false;
    private string[] collectibles;
    private int clue;

    private AudioSource greeting;

    // Start is called before the first frame update
    void Start()
    {
        greeting = GetComponent<AudioSource>();
        collectibles = new string[] { "film", "balloons", "life saver", "bull's eye", "pipe", "key", "fish", "birdhouse", "red airhorn", "magic hat" };
        createClue();
    }

    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialogue();
    }

    public void searchDialogue()
    {
        switch (clue)
        {
            case 0:
                dialogue = "I was working on a movie, can you help find my film?";
                break;
            case 1:
                dialogue = "My friend's birthday party is coming up, can you find some balloons?";
                break;
            case 2:
                dialogue = "Ahoy, matey! I need me buoy for me ship! (it's not called a lifesaver lil bro)";
                break;
            case 3:
                dialogue = "They're taking the hobbits to Eisengard! Help me find my bullseye!";
                break;
            case 4:
                dialogue = "Mr. Watson's not here, could you fetch my pipe for me?";
                break;
            case 5:
                dialogue = "I'll give you the count of 1 two 10 to find a key. And keep the change, ya filthy animal.";
                break;
            case 6:
                dialogue = "Someone stole my fish! Oh brother, this guy stinks!";
                break;
            case 7:
                dialogue = "Help! Pierre Pollievre wasn't elected and my bird can't afford a home!";
                break;
            case 8:
                dialogue = "WHAT ARE THOSE! I'm in Major League Gaming, but I lost my airhorn. Can you help?";
                break;
            case 9:
                dialogue = "*cough *couch Hey, I'm getting old and Teller won't talk to me. Can you go fetch my hat?";
                break;
            default:
                dialogue = "Hi! Can you help me find my " + collectibles[clue] + "?";
                break;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!begin && pHolding.Verify())
        {
            checkClue();
        }
        greeting.Play(0);
        interfaceManager.GetComponent<InterfaceManager>().ShowBox(dialogue, clue);
    }

    private void checkClue()
    {
        if (pHolding.holdValue == clue)
        {
            dialogue = "You found my " + collectibles[clue] + "! Hooray!";
            end = true;
        }
        else
        {
            dialogue = "No, that's not my " + collectibles[clue] + ".";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }

}
