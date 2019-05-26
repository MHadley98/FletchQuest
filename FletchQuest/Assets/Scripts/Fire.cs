using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //check if the thing we collideded with has player script
        Fletcher fletcherScript = collision.collider.GetComponent<Fletcher>();

        //only do something if the player runs into
        if (fletcherScript != null)
        {
            //we did hit player
            fletcherScript.Kill();
        }
    }

}
