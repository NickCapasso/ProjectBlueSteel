using UnityEngine;
using System.Collections;

public class EnhancerBull : MonoBehaviour {
	private Vector3 pos;
	private Vector3 plps;
	private Move moveScript;
	public float maxMult;
	void Start (){
		moveScript=GetComponent<Move>();
		moveScript.turnDelay = 12;
		moveScript.homingPeriod = 100;
		moveScript.isBullet = false;
		moveScript.damage = 0;
		moveScript.tether = 240;
	}
	
	void Update(){
		//if (dist<20.0f){
			moveScript.mult = (maxMult / (moveScript.getDist() + 1));
		//}else{
		//	moveScript.mult = 0;
		//}
	}
}
