using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeClose : MonoBehaviour {

	public float treeSpeed;
	Vector3 dir;

	void Start () {
		dir = this.transform.TransformDirection(Vector3.forward);
	}
	void Update () {
		this.transform.position += dir * treeSpeed * Time.deltaTime;	
	}
}
