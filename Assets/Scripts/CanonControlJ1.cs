using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonControlJ1 : MonoBehaviour 
{
    public float ySpeed = 40f;
    public float xRotationSpeed = 40f;

    [Header("Clamp X (Vertical)")]

    public float minXRotation = 0;
    public float maxXRotation = 0;
    [Header("Clamp Y (Horizontal)")]

    public float minYRotation = 0;
    public float maxYRotation = 0;


    private float currrentYAngle = 0;
    private float currrentXAngle = 0;

    //float XAxis = Input.GetAxis("RightJoystickVerticalJ2");
    //float YAxis = Input.GetAxis("RightJoystickHorizontalJ2");

    void Update () 
    {
        /*currrentXAngle = Mathf.Clamp(currrentXAngle + Input.GetAxis("RightJoystickVerticalJ1"), minXRotation, maxXRotation);
        currrentYAngle = Mathf.Clamp(currrentYAngle + Input.GetAxis("RightJoystickHorizontalJ1") * ySpeed, minYRotation, maxYRotation);

        transform.localEulerAngles = new Vector3(currrentXAngle, currrentYAngle, 0);*/
    }
}
