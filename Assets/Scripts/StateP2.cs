using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StateP2 : MonoBehaviour 
{
	public float HealthPoint = 100;
	private float Health;
	public Image HealtBar;
	public GameObject ScriptToDeactivate;
	public GameObject ScriptToDeactivate_2;
	public GameObject ScriptToDeactivate_3;
	public GameObject CanvasToDeactivate;
	public GameObject DestroyedVersion;




	void Start()
	{
		Health = HealthPoint;
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
		ScriptToDeactivate.GetComponent<MoveP2>().enabled= false;
		ScriptToDeactivate.GetComponent<CanonShootP2>().enabled= false;
		ScriptToDeactivate_2.GetComponent<CanonControlJ2>().enabled= false;
		ScriptToDeactivate_3.GetComponent<CanonShootP1>().enabled=false;
		CanvasToDeactivate.SetActive(false);

		MeshRenderer[] m_meshs = GetComponentsInChildren<MeshRenderer>();
		foreach (var m_mesh in m_meshs)
		{
			m_mesh.enabled =false;
		}
		var tm = Instantiate(DestroyedVersion, transform.position, transform.rotation);
		Destroy(tm,0.01f);
		
		
	}
}
	