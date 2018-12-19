using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HavingByPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		transform.parent = GameObject.Find("Player").transform;
		this.transform.Rotate(-90,0.0f,0.0f);
		Vector3 pos = transform.position;
		pos.y += 1;
		transform.position = pos;
		GameObject.Find("Player").tag = "Umbrella";
		GameObject.Find("Model").tag = "Umbrella";
		GameObject.Find("m01").tag = "Umbrella";
		GameObject.Find("PelvisRoot").tag = "Umbrella";
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
