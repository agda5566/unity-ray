using UnityEngine;
using System.Collections;

public class timepropel : MonoBehaviour {
	private float nextFire = 0.5F;
	private float myTime = 0.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float translation = Time.deltaTime * 10;
		transform.Translate(0, 0, translation);
	}
}
