using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour {

	public void StartGame()
    {
        PlayerPrefs.DeleteKey("score");
        //Loads Level 1
        SceneManager.LoadScene("Level 1-Present");
    }

}
