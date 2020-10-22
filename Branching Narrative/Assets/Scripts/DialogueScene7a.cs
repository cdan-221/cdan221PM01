using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7a : MonoBehaviour
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
    public GameObject ArtChar2;
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
        ArtChar2.SetActive(false);
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
            Char1name.text = "You";
            Char1speech.text = "Hey Ralph.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "What's up?";
            //gameHandler.AddPlayerStat(1);
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            nextButton.SetActive(false);

        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "This place is a popular monster hangout spot.";
        }

        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "How'd you not know when you applied?";
        }

        else if (primeInt == 102)
        {
            Char1name.text = "You";
            Char1speech.text = "Nobody told me that.";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 103)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "Do you have a problem with us lookin' different? Huh?";
        }


        else if (primeInt == 104)
        {
            Char1name.text = "You";
            Char1speech.text = "No, I didn't mean-";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 105)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "Just cause we look different than most people doesn't mean you can be rude about it!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "You";
            Char1speech.text = "There's a playground here?";
            Char2name.text = "";
            Char2speech.text = "";
        }

        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "Did ya miss it on the way in?";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "You";
            Char1speech.text = "Its my first time working a shift this late in the night, so I'm a little out of it.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Ralph";
            Char2speech.text = "It's over to the right side of the store.";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "You";
            Char1speech.text = "Oh ok, thanks.";
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
        Char2name.text = "Ralph";
        Char2speech.text = "Oh, that?";
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
        Char2name.text = "Ralph";
        Char2speech.text = "Nope. Did you check the playground?";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("End_Lose2");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene7b");
    }
}
