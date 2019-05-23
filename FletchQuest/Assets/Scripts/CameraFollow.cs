using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform fletcher;

    Vector3 velocity = Vector3.zero;

    public float smoothTime = .15f;

    //allows enabling and setting of max and min screen clamp
    public bool YMaxEnabled = false;
    public float YMaxValue = 0;

    public bool YMinEnabled = false;
    public float YMinValue = 0;

    public bool XMaxEnabled = false;
    public float XMaxValue = 0;

    public bool XMinEnabled = false;
    public float XMinValue = 0;


    void FixedUpdate()
    {

        //sets target psoition
        Vector3 targetPos = fletcher.position;

        if (YMinEnabled && YMaxEnabled)
            targetPos.y = Mathf.Clamp(targetPos.position.y, YMinValue, YMaxValue);
        else if (YMinEnabled)
            targetPos.y = Mathf.Clamp(targetPos.position.y, YMinValue, targetPos.position.y);

        targetPos.z = transform.position.z;

        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);

    }
    
}
