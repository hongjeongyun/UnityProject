using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour {	
	public static float hRotate = 0;
	void Start () {
		
	}
	void Update()
	{
		Vector2 center = new Vector2(Screen.width * 0.5f,Screen.height * 0.5f);

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