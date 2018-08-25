using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Center
{
	public float x,y;
	public Center(float x1, float y1)
	{
		x = x1;
		y = y1;
	}
}
public class CharacterMove : MonoBehaviour {	
	public static float hRotate = 0;
	void Start () {
		
	}
	void Update()
	{
		
		Center center = new Center(Screen.width * 0.5f,Screen.height * 0.5f);

		Vector3 playerScreenPosion = Camera.main.WorldToScreenPoint(this.transform.position);
		
		if(playerScreenPosion.x > center.x + Screen.width * 0.25f) // 추가로 케릭터가 계속 움직이고 있다고 판정
		{
			hRotate = 1;
			Debug.Log(hRotate);
		}
		if(playerScreenPosion.x < center.x - Screen.width * 0.25f) // 추가로 케릭터가 계속 움직이고 있다고 판정
		{
			hRotate = -1;
			Debug.Log(hRotate);
		}
		else // 케릭터가 정지
		{

		}
	}
}