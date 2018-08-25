using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckMoving : MonoBehaviour {
	private Vector3 lastPosition;
	public static bool isMoving;
	
	void Start () {
		lastPosition = this.transform.position;
	}
	
	void Update () {
		if(this.transform.position.x != lastPosition.x)
		{
			isMoving = true;
		}
		else
		{
			isMoving = false;
		}
		lastPosition = this.transform.position;
	}
}