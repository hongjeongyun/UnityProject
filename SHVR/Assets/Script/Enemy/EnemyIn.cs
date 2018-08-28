using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIn : MonoBehaviour {
	private bool end = false;
	public float speed;
	private Vector3 screenPoint;
	
	void Start () {
		this.GetComponent<EnemyMoveUD>().enabled = false; // Start 안됨 은 착각
		Vector3 screenPos = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width*0.5f,Screen.height*0.5f,0));
		Vector3 pos = this.transform.position;
		pos.y = screenPos.y;
		this.transform.position = pos;
		screenPoint = GetScreenPointXY(new Vector3(100f,0,0));
		StartCoroutine(Main());
	}
	
	IEnumerator Main()
	{
		while(!end)
		{	
			if(this.transform.position.x == screenPoint.x)
			{
				this.GetComponent<EnemyIn>().enabled = false;
				StartCoroutine(Second());			
				end = true;
			}
			InMove(new Vector3(screenPoint.x,screenPoint.y,this.transform.position.z));
			yield return null;
		}
	}
	IEnumerator Second()
	{
		yield return new WaitForSeconds(1.0f);
		this.GetComponent<EnemyMoveUD>().enabled = true;
	}
	
	void InMove(Vector3 target)
	{
		this.transform.position = Vector3.MoveTowards(this.transform.position,target, speed * Time.deltaTime);
	}
	Vector3 GetScreenPointXY(Vector3 InPosition)
	{
		Vector3 res = Camera.main.ScreenToWorldPoint(new Vector3( (Screen.width * 0.5f) + InPosition.x, (Screen.height * 0.5f) + InPosition.y, 0));
		return res;
	}
}
