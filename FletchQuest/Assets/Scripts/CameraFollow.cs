using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform character;

    void FixedUpdate()
    {
        transform.position = new Vector3(character.position.x, character.position.y, transform.position.z);
  
    }
}
