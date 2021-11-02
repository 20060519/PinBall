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
    //Scoreを表示するテキスト
    private GameObject gameScoreText;

    //スコア
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //シーン中のGameOverTextオブジェクトを取得
        this.gameoverText = GameObject.Find("GameOverText");
        //ScoreTextを取得
        this.gameScoreText = GameObject.Find("Score");
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

       if (collisionInfo.gameObject.tag == "LargeStartTag")
        {
            score += 15;
        }

       if (collisionInfo.gameObject.tag == "SmallCloudTag")
        {
            score += 10;
        }

        if (collisionInfo.gameObject.tag == "LargeCloudTag")
        {
            score += 20;
        }
        //Scoreテキストを表示
        this.gameoverText.GetComponent<Text>().text = score.ToString();
    }
}
