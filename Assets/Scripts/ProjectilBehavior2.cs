using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilBehavior2 : MonoBehaviour 

{
	

	private void OnCollisionEnter(Collision other) 
		{
			GameObject.Find("Player2_Kart").GetComponent<CanonShootP2>().isDestroyed=true;
			Destroy(gameObject);
	
		}

}
