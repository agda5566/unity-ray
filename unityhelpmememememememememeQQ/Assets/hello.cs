using UnityEngine;
using System.Collections;

public class hello : MonoBehaviour {
	public float fireDelta = 5.0F;

	private float nextFire = 5.0F;
	private float myTime = 0.0F;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		myTime = myTime + Time.deltaTime;
		//float translation = Time.deltaTime;
		if (Input.GetButton("Fire1") && myTime>nextFire){
			print ("放開");
			nextFire = myTime + fireDelta;
			nextFire = nextFire - myTime;
			myTime = 0.0F;
		}
	}
}
