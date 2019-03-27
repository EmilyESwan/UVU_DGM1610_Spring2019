using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

	public GameObject currectCheckPoint;
	private Rigidbody2D pcRigid;

	private GameObject player;

	//Particles
	public GameObject deathParticle;
	public GameObject respawnParticle;

	//Respawn Delay
	public float respawnDelay;

	//Point Penalty on Death
	public int pointPenaltyOnDeath;

	//Store Gravity Value
	private float gravityStore;

	//Use this for initialization
	void Start() {
		pcRigid = GameObject.Find("PC").GetComponent<Rigidbody2D>();
		player = GameObject.Find("PC");
	}


	
}
