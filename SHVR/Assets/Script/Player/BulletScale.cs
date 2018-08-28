using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScale : MonoBehaviour {
	private Vector3 startPos;
	private float distance;
	void Start () {
		startPos = this.transform.position;
	}
	void Update () {
		distance = Vector3.Distance(this.transform.position,startPos);
		Debug.Log(distance);
	}
	void FixedUpdate()
	{
		if(distance >=10)
		{
			this.transform.localScale = Vector3.one * 0.01f;
		}
		else
		{
			this.transform.localScale -= Vector3.one * Time.deltaTime;
		}
	}
}
