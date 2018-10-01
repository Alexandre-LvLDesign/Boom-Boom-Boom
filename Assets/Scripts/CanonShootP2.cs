using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanonShootP2 : MonoBehaviour 
{
		private GameObject CannonBall;
		public GameObject CanonHead;
		public GameObject BallPrefab;
		public Transform BallSpawn;
		public float SpawnRadius = 2f;
		public float BallSpeed = 40f;

		private void Update() 
		{
			if(Input.GetButtonDown("FireP2"))
			{
				Fire();
			}
		}

		void Fire()
		{
			CannonBall = Instantiate(BallPrefab, BallSpawn.position, BallSpawn.rotation);
			CannonBall.GetComponent<Rigidbody>().velocity = CannonBall.transform.forward*BallSpeed;

		}

		private void OnDrawGizmos() 
		{
			Gizmos.color = Color.magenta;
			Gizmos.DrawWireSphere(BallSpawn.position,SpawnRadius);
		}
}
