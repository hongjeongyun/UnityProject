using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBottom : MonoBehaviour {
	public float smoothRate = 5.0f;
	
	void Start () {
	}
	void Update () {
		//바닥회전표현은 우선 보류
		if(CharacterMove.hRotate == 1)
		{
			this.transform.eulerAngles = new Vector3(0,Mathf.LerpAngle(this.transform.eulerAngles.y,Main_Camera.targetCamAngle,smoothRate * Time.deltaTime),0);
			Debug.Log("Bottom!!!!!!");
		}
		if(CharacterMove.hRotate == -1)
		{
			this.transform.eulerAngles = new Vector3(0,Mathf.LerpAngle(this.transform.eulerAngles.y,Main_Camera.targetCamAngle,smoothRate * Time.deltaTime),0);
			Debug.Log("Bottom!!!!!!");
		}
	}
}