using UnityEngine;
using System.Collections;

public class KillCounter : MonoBehaviour {
	
	public int kills;
	
	
	// Use this for initialization
	void Start () {
		kills = 0;
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public void incrementKills(){
		kills+= 1;	
	}
	
	public int getKills(){
		return kills;	
	}
	
	public void flush(){
		kills = 0;	
	}
}
