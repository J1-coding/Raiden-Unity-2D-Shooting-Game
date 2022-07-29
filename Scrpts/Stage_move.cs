using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage_move : MonoBehaviour
{
    float currentTime = 0;
    Vector3 dirStageMove;

    float speed1 = 1000;
    float speed2 = 2000;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //게임상태가 Playing 이 아니면??
        if (GameManager.Instance.m_state != GameManager.GameState.Playing)
        {
            // -> 처리하지 못하게 하자.

            currentTime += Time.deltaTime;
            //밑으로 내려가다가
            if (currentTime <= 2.5)
            {
                dirStageMove = Vector3.up;
                transform.position += dirStageMove * speed1 * Time.deltaTime;

            }
            else if (currentTime > 2 && currentTime < 3.5)
            {
                transform.position = transform.position;
            }
            else
            {
                //멈춰
                dirStageMove = Vector3.up;
                transform.position += dirStageMove * speed2 * Time.deltaTime;
                //pos = transform.position;

            }

            return;
        }
    }
}
