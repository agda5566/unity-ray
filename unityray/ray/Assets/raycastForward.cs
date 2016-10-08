using UnityEngine;
using System.Collections;

public class raycastForward : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		//https://docs.unity3d.com/ScriptReference/Physics.Raycast.html
		//RaycastHit hit;可用來設定打到什麼
		//float theDistance;

		Vector3 forward = transform.TransformDirection (Vector3.forward);
		//射線長度
		Debug.DrawRay(transform.position,forward,Color.green);
		//顯示射線
		//10/7會有還沒接觸物體就印出字串的問題
		//10/8更改以下if最後的數字就能減少誤差
		if(Physics.Raycast(transform.position, forward, 1))
		{	//碰到物件顯示
			//theDistance = hit.distance;
			//print (theDistance + " 安安你好" + hit.collider.gameObject.name);
			print("hello");
		}

		//wsad移動
		if(Input.GetKey(KeyCode.D))
		{
			gameObject.transform.position+=new Vector3(0.1f,0,0);
		}
		if(Input.GetKey(KeyCode.A))
		{
			gameObject.transform.position+=new Vector3(-0.1f,0,0);
		}
		if(Input.GetKey(KeyCode.W))
		{
			gameObject.transform.position+=new Vector3(0,0,0.1f);
		}
		if(Input.GetKey(KeyCode.S))
		{
			gameObject.transform.position+=new Vector3(0,0,-0.1f);
		}
	}
}
