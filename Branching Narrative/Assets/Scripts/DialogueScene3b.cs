using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtBG1;
    public GameObject NextScene1Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        NextScene1Button.SetActive(false);
        nextButton.SetActive(true);
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            dialogue.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Ralph said the book should be around here somewhere...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            Char1name.text = "You";
            Char1speech.text = "Ah, here it is.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Register 4 Dummies";
            Char2speech.text = "'To operate the cash registers, first, input the customer's order.'";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "You";
            Char1speech.text = "Isn't that obvious?";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Register 4 Dummies";
            Char2speech.text = "'Then, read out the total to the customer, and recieve their payment. Make sure to give them their change.'";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "You";
            Char1speech.text = "This is just a waste of my time.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Muffled crying";
            Char2speech.text = "C'mon, let us in already! I just want some food! Waaaaah!";
            // Turn off "Next" button, turn on "Choice" buttons


        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 9)
        {
            Char1name.text = "You";
            Char1speech.text = "Uh oh, what's going on out there?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar1.SetActive(false);
            Char1name.text = "You";
            Char1speech.text = "I'd better go see whats happening.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
    }

    public void SceneChange4b()
    {
        SceneManager.LoadScene("Scene4b");
    }
}
