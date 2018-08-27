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
	}
}