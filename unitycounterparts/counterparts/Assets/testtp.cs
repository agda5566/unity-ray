using UnityEngine;
using System.Collections;

public class testtp : MonoBehaviour {

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (transform.gameObject);

	}
	
	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(8, 0, 0);
		print(transform.position.x);
	}
	/*void Example() {
		transform.position = new Vector3(8, 0, 0);
		print(transform.position.x);
	}*/
}
