using UnityEngine;
using System.Collections;

public class GetHit : MonoBehaviour {
	
	private GameObject player;
	public int HP;
	
	void Start(){
		player = GameObject.FindWithTag("Player");	
	}
	void Update(){
		if(HP<=0){
			Destroy(this.gameObject);
		player.GetComponent<KillCounter>().incrementKills();
		}
	}
	public void Damage(int dmg){
		HP-=dmg;
	}
}
