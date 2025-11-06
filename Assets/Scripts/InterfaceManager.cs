using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class InterfaceManager : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public Image seekImage;
    public GameObject npc;
    public GameObject randomSpawn;

    [SerializeField]
    private Sprite[] collectibleSource;
    private int clue;
    private string[] collectible;

    // Start is called before the first frame update
    public void createClue()
    {
        clue = Random.Range(0, 9);
        searchDialogue();
    }

    // Update is called once per frame
    public void searchDialogue()
    {
        dialogueText.text = "help me find skibidi ohio rizzler but also help me skibidi on my " + collectible[clue] + "?";
    }

    public void CollectibleUpdate(int item)
    {

    }

    public void ShowBox(string dialogue, int item)
    {
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

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (!begin && PlayerHolding.Verify())
    //    {
    //        checkClue();
    //    }
    //    greeting.Play(0);
    //    InterfaceManager.GetComponent<InterfaceManager>().ShowBox(dialogueBox, clue);
    //}
    void Start()
    {
        dialogueBox.SetActive(false);

        if (npc.GetComponent<DialogueOpen>().begin)
        {
            scatterCoins();
        }
    }
}
