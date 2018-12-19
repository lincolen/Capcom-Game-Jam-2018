using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testPlayerController : MonoBehaviour {

	public float speed = 8f;
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Input.GetAxisRaw("Horizontal") * speed * Time.deltaTime,0,0);
	}
}
