using UnityEngine;
using System.Collections;

public class dell : MonoBehaviour {
	//http://home.gamer.com.tw/creationDetail.php?sn=2661693
	// Use this for initialization
	void Start () {
		//Destroy (gameObject);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnMouseDown ()
	{
		Destroy(gameObject);
		print ("被消失啦~~");
	}
	/*void OnMouseDown (Collider other)
	{
		if (other.tag == "Bull")
		{
			Destroy(other.gameObject);
			print ("銷毀");
		}
	}*/
}
