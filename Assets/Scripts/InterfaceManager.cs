using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;
using System;

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
    Sprite collectible0 = myImage.sprite;

    // Start is called before the first frame update
    
    
    void Start()
    {
        int random = UnityEngine.Random();
        int randomNumber = UnityEngine.Random.Range(0, 9); // Generates a number from 0 to 9
        if (collectable0.sprite == collectable0)
        {
            zero();
        }
        else if (randomNumber == 1)
        {
            one();
        }
        else if (randomNumber == 2)
        {
            two();
        }
        else if (randomNumber == 3)
        {

        }
        else if (randomNumber == 4)
        {

        }
        else if (randomNumber == 5)
        {

        }
        else if (randomNumber == 6)
        {

        }
        else if (randomNumber == 7)
        {

        }
        else if (randomNumber == 8)
        {

        }
        else if (randomNumber == 9)
        {

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
        clue = Random.Range(0, 9);
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
