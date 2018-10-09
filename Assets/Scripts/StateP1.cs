using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateP1 : MonoBehaviour 
{
	public float HealthPoint = 100;
	private float Health;
	public GameObject DeathEffect;
	public Image HealtBar;


	void Start()
	{
		Health = HealthPoint;
	}

	public void Damaged ( float Amount)
	{
		HealthPoint -= Amount;
		HealtBar.fillAmount =  Health / HealthPoint;
		
	}
}
