using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    Vector2 MousePosition1;
    Vector2 MousePosition2;
    //Camera Camera;
    Vector3 dir;
    Transform target;
    GameObject player;

    bool first = true;
    // Start is called before the first frame update
    void Start()
    {
        //Camera = GameObject.Find("MainCamera").GetComponent<Camera>();
        player = GameObject.Find("Player");
        target = player.transform;

    }

    // Update is called once per frame
    void Update()
    {
        // 마우스를 클릭한 그순
        if(Input.GetMouseButtonDown(0))
        {
            if (first == true)
            {
                MousePosition1 = Input.mousePosition;
                first = false;
            }
        }
        else if (Input.GetMouseButton(0))
        {
            MousePosition2 = Input.mousePosition;
            dir = MousePosition2 - MousePosition1;
            dir.Normalize();

            target.transform.position += dir * 5 * Time.deltaTime;
        }
        
        else if (Input.GetMouseButtonUp(0))
        {
            first = true;
        }
    }
 
    
}
