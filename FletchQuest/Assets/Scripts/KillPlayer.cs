using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collideded with has Fletcher script
        Fletcher fletcherScript = collision.collider.GetComponent<Fletcher>();

        //if it is Fletcher
        if (fletcherScript != null)
        {
            //deletes Fletcher's position for tt
            PlayerPrefs.DeleteKey("xPos");
            PlayerPrefs.DeleteKey("yPos");
            //kill Fletcher
            fletcherScript.Kill();
        }
    }

}
