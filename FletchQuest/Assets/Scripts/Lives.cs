using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class Lives : MonoBehaviour {

    public Text livesText;

    private int fletchLives = 4;


	// Use this for initialization
	void Start () {

        fletchLives = PlayerPrefs.GetInt("lives", 4);

        livesText.text = fletchLives.ToString();

    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoseLife()
    {

        fletchLives = fletchLives - 1;

    }


    public void SaveLives()
    {

        PlayerPrefs.SetInt("lives", fletcherLives);

    }

    public bool IsGameOver()
    {
        if (numericalLives <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
