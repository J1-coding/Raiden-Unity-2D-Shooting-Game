using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    //점수를 관리하고 UI표시를 하고 싶다
    //현재점수 , 최고점수 , 현재점수 UI , 최고점수 UI

    //점수관리 
    //적을 잡을때마다 현재점수 1점 증가시키기
    //현재 점수가 최고점수를 넘어서면 최고점수 갱신해주기

    int curScore = 0;
    int topScore = 0;
    public Text curScoreUI;
    public Text topScoreUI;

    public int CurScore
    {
        get
        {
            return curScore;
        }
        set
        {
            curScore = value;
            curScoreUI.text = curScore + "";
            if (curScore > topScore)
            {
                topScore = curScore;
                topScoreUI.text = topScore + "";

                PlayerPrefs.SetInt("Score", topScore);
            }


        }
    }

    public static ScoreManager Instance;
    private void Awake()
    {
        Instance = this;
        //최초 저장된게 없을떄에는 0을 불러온다 
        topScore = PlayerPrefs.GetInt("Score", 0);
    }

    private void Start()
    {
        //텍스트값을 설정한다
        curScoreUI.text = "" + curScore;
        topScoreUI.text = "Top Score : " + topScore;
    }
}

