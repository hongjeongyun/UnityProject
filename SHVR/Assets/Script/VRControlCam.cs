using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VRControlCam : MonoBehaviour {
	public Camera ConCam;
	private Vector3 dir;
	void Start () {
		
	}
	void Update () {
		dir = ConCam.transform.TransformDirection(Vector3.forward);
		this.transform.position = dir;
	} 
}