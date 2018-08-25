using UnityEngine;
using System.Collections;

public class Main_Camera : MonoBehaviour
{
	public bool IsLockCursor = false;
	public float smoothRate = 5.0f;
	public float turnSpeed;
	public GameObject Player;
	private float targetAngle;
	private string msg = "Main Camera Call!";
	public static float targetCamAngle;
	void Start ()
	{
		Debug.Log($"{msg}");
	}
	void Update ()
	{	
		if(IsLockCursor)
		{
			LockCursor();
		}
	}
	void LateUpdate() // Follow 구현
	{
		//float currYAngle = Mathf.LerpAngle(this.transform.eulerAngles.y,this.transform.eulerAngles.y,smoothRate * Time.deltaTime);
		//Quaternion Qrot = Quaternion.Euler(0,currYAngle,0);
		//this.transform.position = Player.transform.position - (Qrot * Vector3.forward);
		if( CharacterMove.hRotate == 1) 
		{
			_temp_Follow();
			targetCamAngle = GetAngle();
			// 카메라는 팔로우 + 바닥은 회전?
			//Debug.Log("Late Udate : 1");
		}
		if( CharacterMove.hRotate == -1)
		{
			_temp_Follow();
			//Debug.Log("Late Udate : -1");
		}
	}
	void _temp_Follow()
	{
		float targetAngle = GetAngle();
		this.transform.eulerAngles = new Vector3(0,Mathf.LerpAngle(this.transform.eulerAngles.y,targetAngle,smoothRate * Time.deltaTime),0);
	}
	
	float GetAngle()
	{
		Vector3 diff = Player.transform.position - this.transform.position;
		float angle = Mathf.Atan2(diff.z,diff.x) * Mathf.Rad2Deg;
		float res = angle - 90f;
		return res;
	}
	void LockCursor()
	{
		float h = Input.GetAxis("Mouse X");
		Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
		//Screen.lockCursor = true;
	}
	void OnGUI()
	{
		GUI.Box(new Rect(Screen.width * 0.25f,Screen.height*0.25f,Screen.width*0.5f,Screen.height*0.5f),"");
	}
}