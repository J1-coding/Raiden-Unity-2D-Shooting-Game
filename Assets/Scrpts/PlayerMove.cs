using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 사용자 입력에 따라 상하좌우로 이동하고 싶다.
// 필요속성 : 이동속도
public class PlayerMove : MonoBehaviour
{
    // 필요속성 : 이동속도
    float speed = 5;

    float width;

    float currentTime = 0;
    //Vector3 pos;
    Vector3 dirReady;


    // Start is called before the first frame update
    void Start()
    {
        //픽셀당 몇 미터인지
        float worldSize = Camera.main.orthographicSize * 2;
        float meterPerPixel = worldSize / Screen.height;
        width = meterPerPixel * Screen.width * 0.5f  - 1.1f;
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
                dirReady = Vector3.up;
                transform.position += dirReady * speed * Time.deltaTime;



            }
            else if (currentTime > 2.5 && currentTime < 4.5)
            {
                dirReady = Vector3.down;
                transform.position += dirReady * speed * Time.deltaTime;
            }
            else
            {
                //멈춰
                transform.position = transform.position;
                //pos = transform.position;

            }

            return;
        }


        // 사용자 입력에 따라 상하좌우로 이동하고 싶다.
        // 1. 사용자의 입력에 따라
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        // 2. 방향이 필요
        Vector3 dir = Vector3.right * h + Vector3.up * v;
        dir.Normalize();
        // 3. 이동하고 싶다.
        // P = P0 + vt
        Vector3 myPos = transform.position;
        //transform.position += dir * speed * Time.deltaTime;
        myPos += dir * speed * Time.deltaTime;

        //왼쪽으로 오른쪽으로 4.3넘어가지 않도록 하고 싶다
        //myPos.x = Mathf.Clamp(myPos.x, -4.3f, 4.3f);
        myPos.x = Mathf.Clamp(myPos.x, -width, width);
        transform.position = myPos;

        //Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        //if (pos.x < 0f)
        //    pos.x = 0f;
        //if (pos.x > 1f)
        //    pos.x = 1f;
        //if (pos.y < 0f)
        //    pos.y = 0f;
        //if (pos.y > 1f)
        //    pos.y = 1f;
        //transform.position = Camera.main.ViewportToWorldPoint(pos);



    }
}