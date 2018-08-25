using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPmove : MonoBehaviour {
	public float speed;
	Vector3 dir;
	void Start () {
		dir = this.transform.TransformDirection(Vector3.forward);
	}
	
	void Update () {
		this.transform.position += dir * speed * Time.deltaTime;
	}
}
