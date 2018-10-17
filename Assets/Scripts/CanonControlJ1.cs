using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonControlJ1 : MonoBehaviour 
{
    public float ySpeed = 40f;
    public float xRotationSpeed = 40f;

    [Header("Clamp X (Vertical)")]

    private float xAngle;
    public float minXRotation = 0;
    public float maxXRotation = 0;
    [Header("Clamp Y (Horizontal)")]

    private float yAngle;
    public float minYRotation = 0;
    public float maxYRotation = 0;


    private void Start() {
        
    }

    void Update () 
    {
        //Horizontal => regarder de droite à gauche => axe Y =>RightJoystickHorizontalJ1
        //Vertical => Regarder de haut en bas => axe X => RightJoystickVerticalJ1
        xAngle = Input.GetAxis("RightJoystickVerticalJ1");
        yAngle = Input.GetAxis("RightJoystickHorizontalJ1");

        yAngle = Mathf.Clamp(yAngle, -60, 60);
        
        // transform.eulerAngles = new Vector3(xAngle, yAngle ,0.0f);
    

        //transform.Rotate(xAngle, yAngle * ySpeed, 0.0f);
        //transform.eulerAngles.y =
    }
}
