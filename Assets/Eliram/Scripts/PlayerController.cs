using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
	private Rigidbody rb;
	public int speed;
	int rot = 1;
	 Animator animator;


	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody> ();
		animator = GetComponentInChildren<Animator>();
		if (saito.ReadySceneTransition.PlayerSpeed == 0) {
			speed = 3;
		} else {
			speed = saito.ReadySceneTransition.PlayerSpeed;
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate(){
		float moveHorizonatl = Input.GetAxis ("Horizontal");
		//Vector3 movement = new Vector3 (moveHorizonatl, 0.0f, 0.0f);
		Vector3 movement = new Vector3(1.0f,0.0f,0.0f);


		rb.velocity = movement * speed;

		if (movement.x * rot < 0) {
			transform.RotateAround (transform.position, transform.up, 180f);
			rot *= -1;
		}




		if (Mathf.Abs(movement.x) > 0.5f) {
			animator.SetBool ("isWalking", true);
		} else {
			animator.SetBool ("isWalking", false);
		}

	}
}
