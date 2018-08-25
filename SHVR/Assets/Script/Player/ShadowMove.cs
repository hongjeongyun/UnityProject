using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// 그림자는 플레이어의 좌우 위치를 따라움직이며, 플레이어의 상하이동에는 반응하지않는다.
public class ShadowMove : MonoBehaviour {

	public Transform PlayerTransform;
	Vector3 origin;
	public float speed;
	void Start()
	{
		origin = this.transform.position;
	}
	
	void Update () {
		Vector3 pos = this.transform.localPosition;
		pos.x = PlayerTransform.position.x;
		pos.y = origin.y;
		this.transform.localPosition = pos;
	}
}