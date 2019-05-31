using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Extra using statment to allow us to use the scene management functions
using UnityEngine.SceneManagement;

public class ToNextLevel : MonoBehaviour
{
    public string sceneToLoad;
    public Score scoreObject;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collideded with has Fletcher script
        Fletcher playerScript = collision.collider.GetComponent<Fletcher>();

        //run if ran into by player
        if (playerScript != null)
        {
            //deletes player position for tt
            PlayerPrefs.DeleteKey("xPos");
            PlayerPrefs.DeleteKey("yPos");

            scoreObject.SaveScore();
            //load the next level
            SceneManager.LoadScene(sceneToLoad);
        }
    }
}