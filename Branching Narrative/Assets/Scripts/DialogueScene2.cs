using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2 : MonoBehaviour
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
    public GameObject Choice2a;
    public GameObject Choice2b;
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
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "???";
            Char2speech.text = "Hey, You must be the newbie.";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "I'm Ralph. I'll be working the Kitchen while you're on the register. If you've got any questions just ask away.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "You";
            Char1speech.text = "Nice to meet you. Do people really come in this late at night?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "You'd be surprised. All kinds of folks come through.";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "You";
            Char1speech.text = "Noted. Is there anything else I need to know?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "Not really, as long as you know how to work the register.";
        }
        else if (primeInt == 8)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "If you're not sure, you can go look through the manual in the storage room.";
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice2a.SetActive(true); // function Choice1aFunct()
            Choice2b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "If you're sure, then I'll just be over in the kitchen.";
        }
        else if (primeInt == 101)
        {
            Char1name.text = "You";
            Char1speech.text = "Alright.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "Alright, I'll man the front for now. Come back out when you're ready.";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "You";
            Char1speech.text = "Thanks.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice2aFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "Nah, I'm good. I've done register work before, it's all the same.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice2bFunct()
    {
        Char1name.text = "You";
        Char1speech.text = "I think i'll go check that manual, just to make sure.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange3a()
    {
        SceneManager.LoadScene("Scene3a");
    }
    public void SceneChange3b()
    {
        SceneManager.LoadScene("Scene3b");
    }
}
