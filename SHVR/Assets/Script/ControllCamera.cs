using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllCamera : MonoBehaviour {
	public float MaxAngle;
	public float MinAngle;
	public float rotSpeed;
	void Start () {
	}
	void Update () {
		//Debug.Log(this.transform.rotation.x);
		//Debug.Log(Input.GetAxis("Mouse Y"));
		
		if( Input.GetAxis("Mouse Y") < 0 && this.transform.rotation.x <= 0.25f)
		{	
			this.transform.Rotate(new Vector3(1,0,0) * rotSpeed * Time.deltaTime);	
		}
		if(Input.GetAxis("Mouse Y") > 0 && this.transform.rotation.x >= -0.25f)
		{
			this.transform.Rotate(new Vector3(-1,0,0) * rotSpeed * Time.deltaTime);
		}
		if(Input.GetAxis("Mouse X") > 0)
		{
			this.transform.Rotate(new Vector3(0,1,0) * rotSpeed * Time.deltaTime);
		}
		if(Input.GetAxis("Mouse X") < 0)
		{
			this.transform.Rotate(new Vector3(0,-1,0) * rotSpeed * Time.deltaTime);
		}
	}
}