using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectilBehavior : MonoBehaviour 
{
	private void OnCollisionEnter(Collision other) 
		{
			Destroy(gameObject);
		}

}
