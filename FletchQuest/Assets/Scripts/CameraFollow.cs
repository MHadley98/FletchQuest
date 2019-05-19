using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform fletcher;

    void FixedUpdate()
    {
        transform.position = new Vector3(fletcher.position.x, fletcher.position.z);
    }
}
