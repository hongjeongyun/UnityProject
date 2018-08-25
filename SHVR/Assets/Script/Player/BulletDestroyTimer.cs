using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroyTimer : MonoBehaviour {
	public float Time = 2.0f;
	void Start()
	{
		StartCoroutine(DestroyTimer(Time));
	}
	IEnumerator DestroyTimer(float time)
	{
		yield return new WaitForSeconds(time);
		Destroy(this.gameObject);
	}
}