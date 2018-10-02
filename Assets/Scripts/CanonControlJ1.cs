using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonControlJ1 : MonoBehaviour 
{
    public float ySpeed = 40f;
    public float xRotationSpeed = 40f;

    private void Update() 
    {
        float translation = Input.GetAxis("RightJoystickVerticalJ1")*ySpeed;
        float rotation = Input.GetAxis("RightJoystickHorizontalJ1") * xRotationSpeed;
        translation*=Time.deltaTime;
        rotation*=Time.deltaTime;
        transform.Translate(0,0,translation);
        transform.Rotate(0,rotation,0);
    }
}
