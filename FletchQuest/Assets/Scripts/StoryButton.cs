﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class StoryButton : MonoBehaviour {

	public void GoToMenu () {
        SceneManager.LoadScene("Story Menu");
    }
}