using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using UnityEditor.Experimental.GraphView;

public class InterfaceManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public Image seekImage;
    public GameObject npc;
    public GameObject randomSpawn;
    public Image collectable;
    public GameObject showSprite;
    public Sprite collectable0;
    [SerializeField]
    private Sprite[] collectibleSource;
    private int clue;
    private string[] collectible;
    public Image myImage;
    Sprite collectible0;

    // Start is called before the first frame update
    
    
    void Start()
    { // Generates a number from 0 to 9
        if (clue == 0)
        {
            zero();
        }
        else if (clue == 1)
        {
            one();
        }
        else if (clue == 2)
        {
            two();
        }
        else if (clue == 3)
        {
            three();
        }
        else if (clue == 4)
        {
            four();
        }
        else if (clue == 5)
        {
            five();
        }
        else if (clue == 6) 
        {
            sixSeven(); 
        }
        else if (clue == 7)
        {
            UncOfSixSeven();
        }
        else if (clue == 8)
        {
            eight();
        }
        else if (clue == 9)
        {
            nine();
        }
        dialogueBox.SetActive(false);
        showSprite.SetActive(false);

        if (npc.GetComponent<DialogueOpen>().begin)
        {
            scatterCoins();
        }
    }

    void Update()
    {
        if (Input.GetButton("Submit") && dialogueBox.activeInHierarchy) 
        {
            dialogueBox.SetActive(false);

            if (npc.GetComponent<DialogueOpen>().end)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
    public void createClue()
    {
        clue = UnityEngine.Random.Range(0, 9);
        searchDialogue();
    }

    // Update is called once per frame
    public void searchDialogue()
    {
        dialogueText.text = "Im skibidi, so help me skibidi on my " + collectible[clue] + "?";
    }

    public void CollectibleUpdate(int item)
    {
        showSprite.SetActive(true);
        collectable.GetComponent<Image>().sprite = collectibleSource[item];
    }

    public void ShowBox(string dialogue, int item)
    {
        dialogueBox.SetActive(true);
        dialogueText.text = dialogue;
        seekImage.GetComponent<Image>().sprite = collectibleSource[item];
        if (npc.GetComponent<DialogueOpen>().begin)
        {
            scatterCoins();
        }
    }

    public void scatterCoins()
    {
        randomSpawn.GetComponent<RandomSpawn>().DistributeCollectibles();
        npc.GetComponent<DialogueOpen>().coinsScattered();
    }

    private void zero()
    {
        dialogueText.text = "Help me record the 5th shrek movie with the " + collectible[clue] + "!";
    }

    private void one()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
    private void two()
    {
        dialogueText.text = "SOMEONES DROWNING HURRY " + collectible[clue] + "!";
    }
    private void three()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
    private void four()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
    private void five()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
    private void sixSeven()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
    private void UncOfSixSeven()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
    private void eight()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
    private void nine()
    {
        dialogueText.text = "My son wants his " + collectible[clue];
    }
}
