using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public Vector3 v3random;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown ()
	{
		//Debug.Log("12312");
		v3random= new Vector3(Random.Range(-5.5f,5f),0.92f,Random.Range(17,30));
		transform.position = v3random;
		print(transform.position.x);
	}
}
