using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //게임의 진행상태를 관리하고 싶다
    //필요속성: 현재상태 , Ready, Start, Playing, GameOver
    //[SerializeField]
    //[System.NonSerialized]
    //[HideInInspector]

    //public int Ready = 0;
    //public int Starts = 1;
    //public int Playing = 2;
    //public int GameOver = 3;

    public enum GameState
    {
        Ready,
        Start,
        Playing,
        Gameover
    };

    public GameState m_state = GameState.Ready;

    public static GameManager Instance;

    private void Awake()
    {
        Instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        print("state: " + m_state);
        switch(m_state)
        {
            case GameState.Ready:
                ReadyState();
                break;
            case GameState.Start:
                StartState();
                break;
            case GameState.Playing:
                PlayingState();
                break;
            case GameState.Gameover:
                GameoverState();
                break;
        }

        
    }

    float currentTime = 0;
    public float readyDelayTime = 2;
    public float startDelayTime = 2;

    //2초간 기다렸다가 상태를 스타트로 변경하고 싶다 
    private void ReadyState()
    {
        //1.시간이 흘러
        //2. 시간이 됐다
        //3. 상태를 스타트로 변경
        print("레디스테이트 들어옴");
        currentTime += Time.deltaTime;
        print("current time: " + currentTime);
        if (currentTime > readyDelayTime)
        {
            m_state = GameState.Start;
            currentTime = 0;
        }
    }

    private void StartState()
    {
        currentTime += Time.deltaTime;
        if (currentTime > startDelayTime)
        {
            m_state = GameState.Playing;
            currentTime = 0;
        }
    }

    private void PlayingState()
    {
        
    }
    private void GameoverState()
    {

    }
}
