using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIn : MonoBehaviour {
	
	
	
	void Awake()
	{
		this.GetComponent<EnemyMoveUD>().enabled = false; // Start 안됨
	}
	
	void Start () {
		StartCoroutine(Later());
	}
	void Update () {
		
	}

	IEnumerator Later()
	{
		yield return new WaitForSeconds(10.0f);
		this.GetComponent<EnemyMoveUD>().enabled = true;
	}
}
