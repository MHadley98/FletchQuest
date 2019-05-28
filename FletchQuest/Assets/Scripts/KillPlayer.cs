using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collideded with has player script
        Fletcher fletcherScript = collision.collider.GetComponent<Fletcher>();

        //only do something if the player runs into
        if (fletcherScript != null)
        {
            PlayerPrefs.DeleteKey("xPos");
            PlayerPrefs.DeleteKey("yPos");
            //we did hit player
            fletcherScript.Kill();
        }
    }

}
