using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    //ボールが見える可能性のあるz軸の最大値
    private float visiblePoz = -6.5f;

    //ゲームオーバを表示するテキスト
    private GameObject gameoverText;

    //スコア
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
    }

    // Update is called once per frame
    void Update()
    {
        //ボールが画面外に出た場合
        if (this.transform.position.z < this.visiblePoz)
        {
            //GameoverTextにゲームオーバを表示
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.gameObject.tag == "SmallStar")
        {
            //スコアを加算する
            score += 5;
        }

       if (collisionInfo.gameObject.tag == "LargeStar")
        {
            score += 15;
        }

       if (collisionInfo.gameObject.tag == "SmallCloud")
        {
            score += 10;
        }

        if (collisionInfo.gameObject.tag == "LargeCloud")
        {
            score += 20;
        }
    }
}
