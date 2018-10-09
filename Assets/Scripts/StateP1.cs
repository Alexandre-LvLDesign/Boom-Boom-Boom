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
	
	public GameObject ScriptToDeactivate;
	public GameObject ScriptToDeactivate_2;


	void Start()
	{
		Health = HealthPoint;
		//myScript = gameObject.GetComponent<CustomScript>();
	}

	public void Damaged ( float Amount)
	{
		HealthPoint -= Amount;
		HealtBar.fillAmount =  HealthPoint / Health;

		if (HealthPoint <= 0)
		{
			Die();
		}
		
	}
	private void Die()
	{
		Instantiate(DeathEffect, transform.position, transform.rotation);
		ScriptToDeactivate.GetComponent<MoveP1>().enabled= false;
		ScriptToDeactivate.GetComponent<CanonShootP1>().enabled= false;
		ScriptToDeactivate_2.GetComponent<CanonControlJ1>().enabled= false;
		
	}
}
	