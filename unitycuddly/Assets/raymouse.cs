using UnityEngine;
using System.Collections;

public class raymouse : MonoBehaviour {
	public LayerMask wallLayer;
	public LayerMask roundLayer;
	public LayerMask cylinderLayer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		

		//Vector3 fwd = transform.trans

		if (Input.GetMouseButton(0))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Vector3 pos = gameObject.transform.localPosition;
			//Ray ray =new Ray(pos,Input.mousePosition);
			RaycastHit hit;
			//Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
			//Debug.Log(hit.transform.name);
			if (Physics.Raycast (ray, out hit,100, wallLayer.value)) {
				print ("這是牆壁");
				Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
				Debug.Log(hit.transform.name);
			}
			if (Physics.Raycast (ray, out hit,100, roundLayer.value)) {
				print ("這是圓形");
				Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
				Debug.Log(hit.transform.name);
			}
			if (Physics.Raycast (ray, out hit,100, cylinderLayer.value)) {
				//print ("這是圓柱體");
				//transform.position = new Vector3(8, 0, 0);
				//print(transform.position.x);
				Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
				Debug.Log(hit.transform.name);
			}

			/*if (Physics.Raycast (ray, out hit,100f)) {
				
				Debug.DrawLine(Camera.main.transform.position, hit.transform.position, Color.red, 0.1f, true);
				Debug.Log(hit.transform.name);
			}*/
		}
	}
}
