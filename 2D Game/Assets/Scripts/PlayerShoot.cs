using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	public Transform firePoint;
	public GameObject projectile;

	void Start () {
		//Load projectile from Resources/Prefabs folder
		projectile = Resources.Load("Prefabs/Projectile") as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)){
			Instantiate(projectile,firePoint.position,firePoint.rotation);
		}
	}
}
