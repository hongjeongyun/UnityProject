using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public struct Center1
{
	public float x,y;
	public Center1(float x1, float y1)
	{
		x = x1;
		y = y1;
	}
}

public class Move : MonoBehaviour {
	private float h,v = 0;
	public float speed = 10f;
	public static int hRotate = 0;
	void Start () {
	}
	void Update () {
		Center1 center = new Center1(Screen.width * 0.5f,Screen.height * 0.5f);
		Vector3 pos = this.transform.localPosition;
	    if(Input.GetAxis("Mouse Y") >0)
		//if(Input.mousePosition.y > center.y)
		{
			v = 1;
			Debug.Log(v);
		}
		if(Input.GetAxis("Mouse Y") <0)
		//if(Input.mousePosition.y < center.y)
		{
			v = -1;
			Debug.Log(v);
		}
		
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		
		pos.x = mousePosition.x;
		
		//if(v == -1 && pos.y >= -0.4f || v == 1 && pos.y <=0.4f) // 동작함, h 값을 바꾸는 비교는 적절하지 않다. 
			pos.y = mousePosition.y;
		
		this.transform.localPosition = pos;
		
		Vector3 playerScreenPos = Camera.main.WorldToScreenPoint(pos);
		
		if(playerScreenPos.x > center.x + Screen.width * 0.25) // OK 작동함
		{
			//Debug.Log("R");
			hRotate = 1;
			//Debug.Log(hRotate);
		}
		if(playerScreenPos.x < center.x - Screen.width * 0.25)
		{
			//Debug.Log("L");
			hRotate = -1;
			//Debug.Log(hRotate);
		}
		//if (v < 0  && pos.y >= -0.4f || v > 0 && pos.y <= 0.4f)
	}
}
