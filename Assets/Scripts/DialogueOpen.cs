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
    private Sprite collectible0;
    private Sprite collectible1;
    private Sprite collectible2;
    private Sprite collectible3;
    private Sprite collectible4;
    private Sprite collectible5;
    private Sprite collectible6;
    private Sprite collectible7;
    private Sprite collectible8;
    private Sprite collectable9;

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
            dialogue = "You skibidied on my " + collectibles[clue] + "! Skibidi ohio sigma rizz!";
            end = true;
        }
        else
        {
            dialogue = "Tralelo tralala! thats not Brr Brr Patapim " + collectibles[clue] + ".";
        }
    }

    public void coinsScattered()
    {
        begin = false;
    }
    public void switchp()
    {
        switch (clue)
        {
            case 1:
                dialogue = "test1" + collectibles[clue];
                break;
            case 2:
                dialogue = "test2" + collectible2;
                break;
            case 3:
                dialogue = "test2" + collectible3;
                break;
            case 4:
                dialogue = "test2" + collectible4;
                break;
            case 5:
                dialogue = "test2" + collectible5;
                break;
            case 6:
                dialogue = "test2" + collectible6;
                break;
            case 7:
                dialogue = "test2" + collectible7;
                break;
            case 8:
                dialogue = "test2" + collectible8;
                break;
            case 9:
                dialogue = "test2" + collectable9;
                break;
            case 0:
                dialogue = "test2" + collectible0;
                break;
        }

    }
}