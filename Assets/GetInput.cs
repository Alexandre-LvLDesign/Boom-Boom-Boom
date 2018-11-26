using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum NumberPlayer 
{
	J1 = 0,
	J2
}
public class GetInput : MonoBehaviour 
{
	public float Shoot;
	public float HorizontalMovement;
	public float RotationX;
	public float RotationY;
	[SerializeField] private NumberPlayer m_NumberPlayer;

	private void Start() 
	{
		transform.tag = m_NumberPlayer.ToString();

		foreach (Transform child in transform)
            child.gameObject.tag = m_NumberPlayer.ToString();
	}


	private void Update() 
	{
		InputFunc();
	}

	void InputFunc()
	{
		RotationX= Input.GetAxis("RightJoystickVertical_" + tag);
		RotationY= Input.GetAxis("RightJoystickHorizontal_" + tag);
		HorizontalMovement = Input.GetAxisRaw("LeftJoystickHorizontal_" + tag);
		Shoot = Input.GetAxisRaw("RightTrigger_" + tag);
	}
}
