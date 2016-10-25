using UnityEngine;
using System.Collections;

public class die : MonoBehaviour {
	//https://youtu.be/B7hGuuZshMA
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown ()
	{
		Destroy(gameObject);
		print ("被消失啦~~");
	}
}
