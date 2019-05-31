using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour {

    public void GoToMenu()
    {
        //Loads Control Menu
        SceneManager.LoadScene("Control Menu");
    }
}
