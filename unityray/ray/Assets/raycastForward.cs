using UnityEngine;
using System.Collections;

public class raycastForward : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		//float theDistance;

		Vector3 forward = transform.TransformDirection (Vector3.forward) * 5;
		//射線長度
		Debug.DrawRay(transform.position,forward,Color.green);
		//顯示射線
		if(Physics.Raycast(transform.position,(forward),out hit))
		{	//碰到物件顯示
			//theDistance = hit.distance;
			//print (theDistance + " 安安你好" + hit.collider.gameObject.name);
			print("hello");
		}

		//wsad移動
		if(Input.GetKey(KeyCode.D))
		{
			gameObject.transform.position+=new Vector3(0.5f,0,0);
		}
		if(Input.GetKey(KeyCode.A))
		{
			gameObject.transform.position+=new Vector3(-0.5f,0,0);
		}
		if(Input.GetKey(KeyCode.W))
		{
			gameObject.transform.position+=new Vector3(0,0,0.5f);
		}
		if(Input.GetKey(KeyCode.S))
		{
			gameObject.transform.position+=new Vector3(0,0,-0.5f);
		}
	}
}
