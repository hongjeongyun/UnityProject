using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIn : MonoBehaviour {
<<<<<<< HEAD
	public float speed;
=======
>>>>>>> 57f3864400c42eaa3f85cc780f072a23e30e657b
	void Awake()
	{
		this.GetComponent<EnemyMoveUD>().enabled = false; // Start 안됨
	}
	void Start () {
		//StartCoroutine(Later());
	}
	void Update()
	{
		Vector3 screenCenter = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width*0.5f+100f,Screen.height*0.5f,0));
		InMove(new Vector3(screenCenter.x,screenCenter.y,this.transform.position.z));
	}
	IEnumerator Later()
	{
		yield return new WaitForSeconds(5.0f);
		this.GetComponent<EnemyIn>().enabled = false;
		this.GetComponent<EnemyMoveUD>().enabled = true;
	}
	void InMove(Vector3 target)
	{
		this.transform.position = Vector3.MoveTowards(this.transform.position,target, speed * Time.deltaTime);
	}
}
