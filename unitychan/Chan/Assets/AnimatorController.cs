using UnityEngine;
using System.Collections;

public class AnimatorController : MonoBehaviour {
	public Animator animator;
	void Start () {
		animator = gameObject.GetComponent<Animator> ();
	}
	
	void Update () {
		// 把角色的速度值傳給 animator 中的 velocity
		animator.SetFloat ("velocity", this.GetComponent<Rigidbody>().velocity.magnitude);
	}
}
