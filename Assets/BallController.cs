using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BallController : MonoBehaviour
{
    //�{�[����������\���̂���z���̍ő�l
    private float visiblePoz = -6.5f;

    //�Q�[���I�[�o��\������e�L�X�g
    private GameObject gameoverText;
    //Score��\������e�L�X�g
    private GameObject gameScoreText;

    //�X�R�A
    private int score = 0;

    // Use this for initialization
    void Start()
    {
        //�V�[������GameOverText�I�u�W�F�N�g���擾
        this.gameoverText = GameObject.Find("GameOverText");
        //ScoreText���擾
        this.gameScoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        //�{�[������ʊO�ɏo���ꍇ
        if (this.transform.position.z < this.visiblePoz)
        {
            //GameoverText�ɃQ�[���I�[�o��\��
            this.gameoverText.GetComponent<Text>().text = "Game Over";
        }

    }

    private void OnCollisionEnter(Collision collisionInfo)
    {
       if (collisionInfo.gameObject.tag == "SmallStar")
        {
            //�X�R�A�����Z����
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
        //Score�e�L�X�g��\��
        this.gameoverText.GetComponent<Text>().text = score.ToString();
    }
}
