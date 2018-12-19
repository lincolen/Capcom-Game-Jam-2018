using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
    /*作成：木村優*/

    // プレイヤーオブジェクト
    GameObject Player;
    GameObject MainCamera;

	// Use this for initialization
	void Start () {
        // プレイヤータグ検索
        Player = GameObject.FindGameObjectWithTag("Player");
        //Player = GameObject.Find("Missile");
        MainCamera = GameObject.FindGameObjectWithTag("MainCamera");

        MainCamera.transform.position = new Vector3(0.0f, 0.0f, 0.0f);
    }
	
	// Update is called once per frame
	void Update () {

        MainCamera.transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y - 5.0f, Player.transform.position.z - 20);
    }
}
