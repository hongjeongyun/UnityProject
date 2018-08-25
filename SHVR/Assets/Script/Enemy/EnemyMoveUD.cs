using System.Collections;
using System.Collections.Generic;
using UnityEngine;


	public class EnemyMoveUD : MonoBehaviour {
		public float offset;
		public float udSpeed;
		Vector3 origin;
		int dir;
		void Start () {
			origin = this.transform.position;
			dir = -1;
			StartCoroutine(Updown());
		}
		IEnumerator Updown()
		{
			while(true)
			{
				Vector3 pos = this.transform.position;
				Vector3 diff = origin - pos;
				if(dir == 1) pos.y += 1f * udSpeed * Time.deltaTime;
				if(dir == -1) pos.y -=1f * udSpeed * Time.deltaTime;
				
				if(diff.y <=-offset) dir = -1;
				if(diff.y >=offset) dir = 1;
				
				this.transform.position = pos;
				yield return null;
			}
		}
	}