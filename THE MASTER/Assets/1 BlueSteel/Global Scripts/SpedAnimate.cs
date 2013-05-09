using UnityEngine;
using System.Collections;

public class SpedAnimate : MonoBehaviour {
	
	public float speedAnim;
	
	void Start () {
		foreach (AnimationState state in animation) {            
			state.speed = speedAnim;
		}
	}
}
	
