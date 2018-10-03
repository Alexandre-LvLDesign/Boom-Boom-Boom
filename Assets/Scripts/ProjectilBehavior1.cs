using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilBehavior1 : MonoBehaviour 
{




	private void OnCollisionEnter(Collision other) 
		{
			GameObject.Find("Player1_Kart").GetComponent<CanonShootP1>().isDestroyed=true;
			Destroy(gameObject);
	
		}
		


}
