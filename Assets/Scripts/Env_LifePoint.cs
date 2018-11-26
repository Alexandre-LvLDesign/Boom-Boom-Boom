using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Env_LifePoint : MonoBehaviour 
{

	public float HealthPoint = 100;
	private float Health;


	private void Start() 
	{

			Health = HealthPoint;
		
	}

	//Gestion PV
	public void Damaged ( float Amount)
	{
		HealthPoint -= Amount;

		if (HealthPoint <= 0)
		{
			Die();
		}
		
	}

	//Gestion Die
	private void Die()
	{
		MeshRenderer[] m_meshs = GetComponentsInChildren<MeshRenderer>();
		foreach (var m_mesh in m_meshs)
		{
			m_mesh.enabled =false;
		}
		
	}
}

