using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {
	public float Time;
	public GameObject Enemy;
	void Start () {
		StartCoroutine(InstantiateEnemy());	
	}
	
	IEnumerator InstantiateEnemy()
	{
		while(true)
		{
			yield return new WaitForSeconds(Time);
			Instantiate(Enemy,this.transform.position,this.transform.rotation);
		}
	}
}