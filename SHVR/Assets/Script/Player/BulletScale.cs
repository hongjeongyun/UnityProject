using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScale : MonoBehaviour {
	void Start () {
		
	}
	void Update () {
		if(this.transform.localScale.x >=0.0000001f && this.transform.localScale.y >=0.0000001f && this.transform.localScale.z >=0.0000001f)
		  this.transform.localScale -= new Vector3(Time.deltaTime,Time.deltaTime,Time.deltaTime);	
	}
}
