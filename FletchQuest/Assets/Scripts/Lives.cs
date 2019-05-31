using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.UI;

public class Lives : MonoBehaviour {

    private int fletchLives = 4;
    public Animator livesAnimator;

    void Start () {
        //Sets Fletcher's lives to 4
        fletchLives = PlayerPrefs.GetInt("lives", 4);


    }
	
	//Updates health bar to diplay correct number of lives
	void Update () {

        livesAnimator.SetInteger("Lives", (fletchLives));

    }

    //Takes away lives
    public void LoseLife()
    {
        fletchLives = fletchLives - 1;
    }

    //Saves Fletcher's current lives
    public void SaveLives()
    {

        PlayerPrefs.SetInt("lives", fletchLives);

    }

    //Checks to see if Fletcher has run out of lives
    public bool IsGameOver()
    {
        if (fletchLives <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
