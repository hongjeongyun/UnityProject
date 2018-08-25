using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remover : MonoBehaviour {

	void Start () {
		Debug.Log("Remover Call!");
	}
	
	void OnTriggerEnter(Collider other)
	{
		if(other.gameObject.tag == "BULLET" || other.gameObject.tag == "Object")
		{
			Destroy(other.gameObject);
			Debug.Log("DESTROY");
		}
	}
}