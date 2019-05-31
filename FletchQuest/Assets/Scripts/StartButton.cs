using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public void StartGame()
    {
        //deletes previous lives, score and tt position from PlayerPrefs
        PlayerPrefs.DeleteKey("lives");
        PlayerPrefs.DeleteKey("score");
        PlayerPrefs.DeleteKey("xPos");
        PlayerPrefs.DeleteKey("yPos");

        //Loads Level 1-Present
        SceneManager.LoadScene("Level 1-Present");
    }

}
