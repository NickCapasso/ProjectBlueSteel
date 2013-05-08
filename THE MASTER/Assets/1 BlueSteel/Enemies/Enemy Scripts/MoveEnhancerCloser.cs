using UnityEngine;
using System.Collections;

public class MoveEnhancerCloser : MonoBehaviour {
	float dist;
	private Move moveScript;
	private float mult;
	public float maxMult = 0.5f;
	void Start (){
		moveScript=GetComponent<Move>();
		moveScript.turnDelay = 24;
		moveScript.homingPeriod = 100;
		moveScript.isBullet = true;
		moveScript.damage = 12;
		moveScript.tether = 240;
	}
	void Update () {
		dist=moveScript.getDist();
		mult=(2.0f/dist);
		if (mult<maxMult){
			moveScript.mult = mult;
		}else{
			moveScript.mult = maxMult;
		}
	}
}
