using UnityEngine;
using System.Collections;
//카메라가 비추는 방향의 반대로 움직이며 일정위치에서 초기위치로 되돌아간다.
public class ParallaxBottom1 : MonoBehaviour {
	public float scrollSpeed;
	private float initPos;
	private Vector3 initVPos;
	void Start () {
		initPos = this.transform.localPosition.z;
		initVPos = this.transform.localPosition;
	}
	void FixedUpdate()
	{
		this.transform.Translate(new Vector3(0,-scrollSpeed,0));
		float height = GetHeight();
		if(initPos - this.transform.localPosition.z > height*0.3f)
		{
			this.transform.localPosition = initVPos;
		}
	}

	float GetHeight()
	{
		return this.GetComponent<Renderer>().bounds.size.z;
	}
}
