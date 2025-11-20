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
    [SerializeField]
    private Sprite[] collectibleSource;
    private int clue;
    private string[] collectible;
    public Image myImage;
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

    // Start is called before the first frame update


    void Start()
    { // Generates a number from 0 to 9
        //switch (clue)
        //{
        //    case 1:
        //        dialogueText.text = "test1" + collectible1;
        //        break;
        //    case 2:
        //        dialogueText.text = "test2" + collectible2;
        //        break;
        //    case 3:
        //        dialogueText.text = "test2" + collectible3;
        //        break;
        //    case 4:
        //        dialogueText.text = "test2" + collectible4;
        //        break;
        //    case 5:
        //        dialogueText.text = "test2" + collectible5;
        //        break;
        //    case 6:
        //        dialogueText.text = "test2" + collectible6;
        //        break;
        //    case 7:
        //        dialogueText.text = "test2" + collectible7;
        //        break;
        //    case 8:
        //        dialogueText.text = "test2" + collectible8;
        //        break;
        //    case 9:
        //        dialogueText.text = "test2" + collectable9;
        //        break;
        //    case 0:
        //        dialogueText.text = "test2" + collectible0;
        //        break;
        //}
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
    }

    // Update is called once per frame

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
}
