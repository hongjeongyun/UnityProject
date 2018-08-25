using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//입력에 의한 일정간격으로 탄을 발사하는 기능이 있다.
public class CharacterShoot : MonoBehaviour {
	public float shotRepeatTime;
	public Transform FirePos;
	
	private bool bFire;
	public GameObject bulletPrefab;
	void Start()
	{
		bFire = true;
	}
	
	void Update () {
		float shot = Input.GetAxis("Fire1");
		if(shot > 0 && bFire)
		{
			StartCoroutine(BulletShoot());
		}
	}
	
	IEnumerator BulletShoot()
	{
		bFire = false;
		Instantiate(bulletPrefab,FirePos.position,FirePos.rotation);
		yield return new WaitForSeconds(shotRepeatTime);
		bFire = true;
	}
}