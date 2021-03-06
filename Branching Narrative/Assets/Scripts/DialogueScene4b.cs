﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4b : MonoBehaviour
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
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    //public GameObject gameHandler;
    //public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
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
            ArtChar1.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "Monster";
            Char1speech.text = "Waah! Waaaaah!!.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Please don't...";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "Monster";
            Char1speech.text = "WAAAAAAAAAAH!!!!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "OMG... What should I do?";
            //gameHandler.AddPlayerStat(1);
            // Turn off "Next" button, turn on "Choice" buttons
            ArtChar1.SetActive(false);
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }


        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "Monster";
            Char1speech.text = "Really?";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1.SetActive(true);
        }

        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Yeah, Please come in.";
        }

        else if (primeInt == 102)
        {
            Char1name.text = "Monster";
            Char1speech.text = "Okay, Thank you XD";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }



        else if (primeInt == 200)
        {
            Char1name.text = "Mosnter";
            Char1speech.text = "WAAAAAAAH!!!!! You are so mean";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1.SetActive(true);
        }

        else if (primeInt == 201)
        {
            Char1name.text = "Mosnter";
            Char1speech.text = "Buddies! Come here!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
        }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "You";
        Char2speech.text = "Okay, my friend. I will take your order. Please stop crying.";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "You";
        Char2speech.text = "Go away!";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene4a");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("End_Lose2");
    }
}
