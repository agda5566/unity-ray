using UnityEngine;
using System.Collections;

public class mousetest : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.GetMouseButton(0))
			//Debug.Log("Pressed left click.");
	
	}
	void OnMouseDown ()
	{
		Debug.Log("12312");

		transform.position = new Vector3(8,0.92f,0);
		print(transform.position.x);
	}


}
