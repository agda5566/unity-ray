using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {
	public LayerMask wallLayer;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		RaycastHit hit;
		if (Input.GetMouseButton(0) && Physics.Raycast(ray, out hit,wallLayer))
		{
			Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
			Debug.Log(hit.transform.name);
		}

	}
}
