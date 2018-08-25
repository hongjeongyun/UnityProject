using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour {
	public Animator myAni;

	void Start () {
		myAni = this.GetComponent<Animator>() as Animator;
	}
	
	// Update is called once per frame
	void Update () {
		if(this.transform.position.y <= -0.4f)
			myAni.SetBool("ground",true);
		else
			myAni.SetBool("ground",false);
	}
}
