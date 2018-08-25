using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeSpawner : MonoBehaviour {

	public GameObject TreePrefab;
	public float RpeatTime;
	
	void Start () {
		StartCoroutine(CreateTree());
	}
	
	IEnumerator CreateTree()
	{
		while(true)
		{
			Instantiate(TreePrefab,this.transform.position,this.transform.rotation);
			yield return new WaitForSeconds(RpeatTime);
		}
	}
}
