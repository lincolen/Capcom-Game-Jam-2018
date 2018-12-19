using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage : MonoBehaviour {
    /*作成者：木村優*/

    // グローバル変数
    public TextAsset    tex;

    public GameObject   block;
    public GameObject   goal;

    Vector3             SpaceScale;
    Vector3             StagePos;

	// Use this for initialization
	void Start () {
        // ゲームオブジェクトタグ検索

        // スペースサイズ
        SpaceScale = new Vector3(1.0f, 1.0f, 1.0f);
        // 初期位置
        StagePos = new Vector3(0.0f, 0.0f, 0.0f);

        // ステージ作成
        InitStage();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // ステージ初期化
    void InitStage()
    {
        foreach(char Objectname in tex.text)
        {
            // テキストの文字と比較
            if(Objectname == 'B')
            {
                StagePos.x += SpaceScale.x;
                // プレハブの生成(ブロック)
                Instantiate(block, StagePos, Quaternion.identity);
            }
            else if (Objectname == ' ')
            {
                StagePos.x += SpaceScale.x;
            }
            else if (Objectname == '\n')
            {
                StagePos.x = 0;
                StagePos.y -= SpaceScale.y;
            }
            if(Objectname == 'G')
            {
                // プレハブの生成(ゴール)
                Instantiate(goal, StagePos, Quaternion.identity);

                StagePos.x += SpaceScale.x;
            }
        }
    }
}
