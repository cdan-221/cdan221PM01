using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DialogueGameHandler : MonoBehaviour{

        public static int playerStat;
        //public GameObject textGameObject;

        //voidÂ Start () { UpdateScore (); }

        void Update(){                // Remove this function when PauseMenu is added
                if (Input.GetKey("escape")){
                        Application.Quit();
                }
        }

        public void AddPlayerStat(int amount){
                playerStat += amount;
                Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
        }

        //void UpdateScore () {
        //        TextÂ scoreTextB = textGameObject.GetComponent ();
        //        scoreTextB.text = "Score: " + score; }

        public void RestartGame(){
                SceneManager.LoadScene("Scene1");
        }

        public void QuitGame(){
                Application.Quit();
        }
}