using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform fletcher;

    Vector3 velocity = Vector3.zero;

    public float smoothTime = .1f;

    void FixedUpdate()
    {

        Vector3 targetPos = fletcher.position;

        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

    }
    
}
