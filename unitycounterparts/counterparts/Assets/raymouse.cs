using UnityEngine;
using System.Collections;

public class raymouse : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit))
		{
			Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
			Debug.Log(hit.transform.name);
		}
	}
}
