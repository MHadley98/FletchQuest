using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavePosition : MonoBehaviour {

    public GameObject PlayerObject;

	// Use this for initialization
	void Start () {

        Vector3 savedPosition = new Vector3(PlayerPrefs.GetFloat("playerX"), PlayerPrefs.GetFloat("player"), 0);
        PlayerObject.transform.position = savedPosition;

	}
	
	// Update is called once per frame
	void Update () {
        PlayerPrefs.SetFloat("playerX", PlayerObject.transform.position.x);
        PlayerPrefs.SetFloat("playerY", PlayerObject.transform.position.y);

    }
}
