using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour {
	
	//Girl Array
	public string girl1 = "Michelle";
	public string girl2 = "Jennifer";
	public string girl3 = "Diane";
	public string girl4 = "Stacy";
	public string girl5 = "Erin";
	public string girl6 = "Haley";
	
	public string[] girls = new string[]{"Michelle","Jennifer","Diane","Stacy","Erin","Haley"};

	//Boy Array
	public string boy1 = "Jerry";
	public string boy2 = "Kyle";
	public string boy3 = "George";
	public string boy4 = "Larry";
	public string boy5 = "Mason";
	public string boy6 = "Bob";

	public string[] boys = new string[]{"Jerry","Kyle","George","Larry","Mason","Bob"};

	// Use this for initialization
	void Start () {
		
		print(boys[3]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
