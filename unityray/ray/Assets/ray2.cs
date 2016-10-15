using UnityEngine;
using System.Collections;

public class ray2 : MonoBehaviour {
	public float rayLength = 100;
	// 射線擊中資訊
	RaycastHit hit;
	// 設定設線偵測圖層
	public LayerMask wallLayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		RaycastHit hit;
		// 偵測射線判斷，由 自身座標 的 前方 射出，以 rayLength 為長度，並且只偵測 wallLayer 圖層
		if (Physics.Raycast(transform.position, fwd, out hit, rayLength, wallLayer))
		{
			// 繪出起點至射線擊中的綠色線段
			Debug.DrawLine( transform.position, hit.point, Color.green, 0.01f, false);
			// 計算兩點之間中心點
			Vector3 centerPoint =  (transform.position + hit.point) / 2;
			// 繪出起點至中心點的紅色線段
			Debug.DrawLine( transform.position, centerPoint, Color.red, 0.01f, false);
			print ("這是一個牆壁");
		}
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
