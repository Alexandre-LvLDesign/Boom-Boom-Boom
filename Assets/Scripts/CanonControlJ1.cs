using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonControlJ1 : MonoBehaviour 
{
    public float ySpeed = 40f;
    public float xRotationSpeed = 40f;

    [Header("Clamp X (Vertical)")]

    public float xAngle =-105f;
     public float minXRotation = 0;
    public float maxXRotation = 0;
    [Header("Clamp X (Horizontal)")]

    public float yAngle =-105f;
    public float minYRotation = 0;
    public float maxYRotation = 0;

    void Update () 
    {
        /*   clamp ??
        yAngle +=Input.GetAxis("RightJoystickVerticalJ1");
        xAngle +=Input.GetAxis("RightJoystickHorizontalJ1");

        Mathf.Clamp(yAngle,minYRotation, maYRotation );
        Mathf.Clamp(xAngle,minXRotation, maxXRotation );

        transform.eulerAngles = new Vector3(maxXRotation, xAngle ,minXRotation);
        */

        transform.Rotate(Input.GetAxis("RightJoystickVerticalJ1"), Input.GetAxis ("RightJoystickHorizontalJ1") * ySpeed, 0.0f);
        //transform.eulerAngles.y =
    }
}
