using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene7c : MonoBehaviour
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
            Char1speech.text = "(Hanging out in the room)";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 3)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Hey, what're you doing here?";
            ArtChar1.SetActive(false);
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            Char1name.text = "Monster";
            Char1speech.text = "Ummmm, I'm chatting with the air";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1.SetActive(true);
        }
        else if (primeInt == 5)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "...... (Who is the monster taking with?)";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            Char1name.text = "Monster";
            Char1speech.text = "I like this store. Human is fun... I like human...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Yeah yeah, I know you guys love humans";
            ArtChar1.SetActive(false);
            // Turn off "Next" button, turn on "Choice" buttons
            nextButton.SetActive(false);
            allowSpace = false;
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            Char1name.text = "Monster";
            Char1speech.text = "Heeheeheeheeeee~` little kid? yah yah. I saw a bunch of kids around near the playground";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1.SetActive(true);
        }
        else if (primeInt == 101)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Ohhh! Then the kid should be there. I'll check now. Thanks!";
        }
        else if (primeInt == 102)
        {
            Char1name.text = "Monster";
            Char1speech.text = "Okie okie. Please come and visit after you found the kid.";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            Char1name.text = "Monster";
            Char1speech.text = "We're aruguing why I looks so handsome.";
            Char2name.text = "";
            Char2speech.text = "";
            ArtChar1.SetActive(true);
        }
        else if (primeInt == 201)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Oh, interesting...";
        }
        else if (primeInt == 202)
        {
            Char1name.text = "Monster";
            Char1speech.text = "I also talked to Ralph. We grew up in the same town. He gave me a free ice cream...  hehehehe~";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 203)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Yeah, our ice cream tastes...  ";
        }
        else if (primeInt == 204)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Wait, you both grew up, what?!";
        }
        else if (primeInt == 205)
        {
            Char1name.text = "Monster";
            Char1speech.text = "Yeah yeah, we came from the same town. Oh, you thought Ralph is human too?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 206)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "You";
            Char2speech.text = "Wat?!!!!";
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
        Char2speech.text = "Quick question, have you seen a kid around?";
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
        Char2speech.text = "What are you guys talking about?";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }

    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene7b");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("End_Win2");
    }
}
