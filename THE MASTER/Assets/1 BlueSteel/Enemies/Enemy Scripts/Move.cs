using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {	
	private Vector3 myCurrDir;
	// Object Position
	private Vector3 playerDir;	
	// Player Position
	private Vector3 toGo;
	private Vector3 prevToGo;
	public float mult;
	private int homing;
	public int turnDelay;
	public int homingPeriod;
	private GameObject player;
	private float distToGo;
	public bool isBullet;
	public int damage;
	public int tether;
	private Vector3 dir; //Designed to be read by other scripts, not edited.
	void Start(){
		player = GameObject.FindWithTag("Player");
	}
	void Update () {
		myCurrDir=transform.position;
		playerDir=player.transform.position;
		toGo=playerDir-myCurrDir;
		distToGo=toGo.magnitude;
		if(homing == 0 & homingPeriod > 1){	
			toGo/=toGo.magnitude;
			dir=mult*(toGo+prevToGo);
			prevToGo=toGo;
			homing = turnDelay;
			homingPeriod -= 1;
		} else if(homingPeriod == 0) {
			decay();
		} else if(homing > 0){
			homing -= 1;	
		}
		transform.Translate(dir);
		
		if(distToGo < 1.0f){
			player.GetComponent<Controller>().Damage(damage);
			if(isBullet){
				Destroy(this.gameObject);
			}
		}
	}
	public float getDist(){
		return distToGo;	
	}
	public Vector3 getDir(){
		return dir;	
	}
	private void decay(){
		if(tether == 0){
			Destroy(this.gameObject);
		} else {
			tether -= 1;
		}
	}
}
