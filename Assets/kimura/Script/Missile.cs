using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    /*作成者：木村優*/
    GameObject missile;
    GameObject target;
    // 位置
    Vector3 missilePos;
    // 半径
    float R;
    // 角度
    float angle;
    // 初速度
    float v0;
    // 時間
    float time;

    // Use this for initialization
    void Start()
    {
        // ミサイルオブジェクトを検索
        missile = GameObject.FindGameObjectWithTag("Missile");

        target = GameObject.FindGameObjectWithTag("Goal");

        missilePos = new Vector3(0.0f, 0.0f, 0.0f);

        R = 5.0f;

        angle = 0;

        v0 = 100.0f;

        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        V();
        // 回転
        //RotationMissile();
        // 位置更新
        missile.transform.position = missilePos;
    }

    // 回転
    void RotationMissile()
    {
        angle += 3.14f / 180.0f;

        if (angle >= 3.14)
        {
            angle = -3.14f;
        }

        missilePos.x = Mathf.Sin(angle) * R;
        missilePos.z = Mathf.Cos(angle) * R;
    }

    // 斜方投射
    void V()
    {
        time += 0.04f;

        missilePos.y = v0 * Mathf.Sin(39.7f * (3.14f / 180.0f)) * time + (1.0f / 2.0f) * (-9.8f * (time * time));
        missilePos.z = - 1000 + v0 * Mathf.Cos(39.0f * (3.14f / 180.0f)) * time;
    }

    // 
    void OnTriggerEnter(Collider other)
    {
        // ミサイルとゴールの判定
        if (GameObject.FindGameObjectWithTag("Goal"))
        {
            Debug.Log("当たり");
        }
    }
}
