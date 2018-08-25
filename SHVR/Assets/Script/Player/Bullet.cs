using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour {
	public float bulletSpeed;
	
	private Rigidbody bulletRigidBody;
	private Vector3 Dir;
	void Start () {
		bulletRigidBody = this.GetComponent<Rigidbody>();
		Dir = this.transform.TransformDirection(Vector3.forward);
	}
	void Update()
	{
		bulletRigidBody.MovePosition(this.transform.position + Dir * bulletSpeed * Time.deltaTime);
		if(this.transform.localScale.x >=0.0000001f && this.transform.localScale.y >=0.0000001f && this.transform.localScale.z >=0.0000001f)
		  this.transform.localScale -= new Vector3(Time.deltaTime,Time.deltaTime,Time.deltaTime);
	}
}