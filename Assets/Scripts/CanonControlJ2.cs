using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonControlJ2 : MonoBehaviour 
{
    public float ySpeed = 40f;
    public float xRotationSpeed = 40f;
    //float XAxis = Input.GetAxis("RightJoystickVerticalJ2");
    //float YAxis = Input.GetAxis("RightJoystickHorizontalJ2");

    void Update () 
    {
        transform.Rotate(Input.GetAxis("RightJoystickVerticalJ2"), Input.GetAxis ("RightJoystickHorizontalJ2") * ySpeed, 0.0f);
    }
}
