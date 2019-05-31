using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour {

    public Score scoreObject;


    //Allows for setting of each collectables value
    public int collectableValue;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        Fletcher fletcherScript = collision.collider.GetComponent<Fletcher>();

        //If collectable is touched by Fletcher
        if (fletcherScript)
        {
            //Adds collectable score to total
            scoreObject.AddScore(collectableValue);

            //Gets rid of collectable
            Destroy(gameObject);
        }
    }

}
