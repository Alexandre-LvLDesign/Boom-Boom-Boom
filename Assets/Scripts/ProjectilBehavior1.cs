using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilBehavior1 : MonoBehaviour 
{
	public GameObject[] ParticlesToSpawn;
	public float BlastRadius = 5f;



	private void OnCollisionEnter(Collision other) 
		{
			//GameObject.Find("Player1_Kart").GetComponent<CanonShootP1>().isDestroyed=true;
			
			if (other.transform.tag =="WaterSplash") 
			{
				Instantiate(ParticlesToSpawn[4], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag =="TerrainTag")
			{
				/* 
				Collider[] RadiusColliders = Physics.OverlapSphere(transform.position, BlastRadius);
				foreach (Collider NearByObject in RadiusColliders) 
				{

				}
				*/
				
				Instantiate(ParticlesToSpawn[0], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag == gameObject.tag)
			{
				GameObject.Find("Player1_Kart").GetComponent<StateP1>().Damaged(3);
				Instantiate(ParticlesToSpawn[1], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag =="J2")
			{
				GameObject.Find("Player2_Kart").GetComponent<StateP2>().Damaged(10);
				Instantiate(ParticlesToSpawn[1], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag == "TreeTag")
			{
				other.gameObject.GetComponent<Env_LifePoint>().Damaged(10);
				Instantiate(ParticlesToSpawn[2], transform.position, transform.rotation);
				Destroy(gameObject);
			}
			else if (other.transform.tag == "RockTag")
			{
				Instantiate(ParticlesToSpawn[3], transform.position, transform.rotation);
				Destroy(gameObject);
			}else{
				print(other.transform.name);
			}
			
			//Destroy(gameObject);
	
		}	
		
}
