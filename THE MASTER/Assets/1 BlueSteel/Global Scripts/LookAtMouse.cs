using UnityEngine;
using System.Collections;

public class LookAtMouse : MonoBehaviour {
	private Vector3 aim;
	
	void Update () {
		aim = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		aim.y = transform.position.y;
		transform.LookAt(aim);
	}
}
