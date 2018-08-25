using UnityEngine;
using System.Collections;

public class ParallaxBottom : MonoBehaviour {

	//public Rigidbody target;
	public float scrollSpeed;


	private Vector3 initPos;
	
	// Use this for initialization
	void Start () {
		initPos = this.transform.position;
		GameObject objectCopy = GameObject.Instantiate(this.gameObject);
		Destroy(objectCopy.GetComponent<ParallaxBottom>());
		objectCopy.transform.SetParent(this.transform);
		objectCopy.transform.localPosition = new Vector3(this.GetHeight(),0,0);
	}
	
	// Update is called once per frame
	void FixedUpdate()
	{
		//float targetVelocity = target.velocity.z;
		//translate sprite according to target velocity
		this.transform.Translate(new Vector3(0,(-scrollSpeed),0)*Time.deltaTime);
		float height = GetHeight();
		//if(targetVelocity > 0) // 이조건은 바뀔수있다.
		//{
			if(Vector3.Distance(initPos,this.transform.position) > height)
			{
				Debug.Log("OK");
				//this.transform.Translate(0,height,0);
			}
		//}
		// else
		// {
		// 	if(initPos - this.transform.localPosition.y > 0)
		// 	{
		// 		this.transform.Translate(0,-height,0);
		// 	}
		// }
	}

	float GetHeight()
	{
		return this.GetComponent<Renderer>().bounds.size.y;
	}
}
