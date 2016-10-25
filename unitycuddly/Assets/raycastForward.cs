using UnityEngine;
using System.Collections;

public class raycastForward : MonoBehaviour {

	// Use this for initialization


	// Update is called once per frame
	void Update () {
		RaycastHit hit;
		float theDistance;
		//debug raycast in the deitor

		Vector3 forward = transform.TransformDirection (Vector3.forward) * 10;
		Debug.DrawRay (transform.position,forward,Color.green);

		if (Physics.Raycast (transform.position, (forward), out hit)) {
			theDistance = hit.distance;
			print(theDistance + " " + hit.collider.gameObject.name);

		}
	}
}
