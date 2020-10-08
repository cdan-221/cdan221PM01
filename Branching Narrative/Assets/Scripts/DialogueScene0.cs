using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene0 : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!

    public GameObject ArtBG1;
    public GameObject NextScene1Button;

    //public GameObject gameHandler;
    //public AudioSource audioSource;

    void Start()
    {         // initial visibility settings

        ArtBG1.SetActive(true);
        NextScene1Button.SetActive(true);
    }

    public void SceneChange1()
    {
        SceneManager.LoadScene("Scene1");
    }

}