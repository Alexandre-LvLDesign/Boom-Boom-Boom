using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanonAction : MonoBehaviour 
{

	[Header("Health")]
	public float HealthPoint = 100;
	private float Health;
	public GameObject DeathEffect;
	public Image HealtBar;

	[Header("Shot")]
	private GameObject CannonBall;
	public GameObject BallPrefab;
	public Transform BallSpawn;

	public float ShotCooldown = 1f;
	public float GizmoRadius= 2f;
	public float BallSpeed = 40f;
	//public bool isDestroyed = true;

	private GetInput m_InputScript;

	private bool canShoot = true;
	void Start()
	{
		
		m_InputScript = GetComponent<GetInput>();
		Health = HealthPoint;
		//myScript = gameObject.GetComponent<CustomScript>();
	}

	private void Update() 
	{
		if(m_InputScript.Shoot > 0.1f && canShoot/*&& isDestroyed==true*/ )
		{
			Fire();
			Debug.Log("Pressed");
		}
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
		GetComponent<CanonMovement>().enabled= false;
		canShoot = false;
		
	}

	void Fire()
	{
		canShoot = false;
		StartCoroutine(CoolDown());
		CannonBall = Instantiate(BallPrefab, BallSpawn.position, BallSpawn.rotation);
		CannonBall.tag = gameObject.tag;
		CannonBall.GetComponent<Rigidbody>().velocity = CannonBall.transform.forward*BallSpeed;

	}

	private void OnDrawGizmos() 
	{
		Gizmos.color = Color.magenta;
		Gizmos.DrawWireSphere(BallSpawn.position,GizmoRadius);
	}

	IEnumerator CoolDown () 
	{
		yield return new WaitForSeconds(ShotCooldown);
		canShoot = true;
	}
}
