using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ENEMY
{
	public class EnemyCollision : MonoBehaviour {
		void Start () {
			
		}
		
		void OnTriggerEnter(Collider other)
		{
			if(other.tag == "BULLET")
			{
				Debug.Log("HIT");
				Destroy(this.gameObject);
				Destroy(other.gameObject);	
			}
		}
	}
}