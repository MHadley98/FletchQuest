using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class MenuButton : MonoBehaviour {

	// Use this for initialization
	public void GoToMenu() {

        SceneManager.LoadScene("Main Menu");

    }
	
}
