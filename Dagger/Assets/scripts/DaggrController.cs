using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class daggerContlloer : MonoBehaviour
{
    private float speed = 0;
    
    void Start()
    {
        // 오늘 배운거 활용
        //Input.GetMouseButtonDown
        //Input.GetMouseButtonUp
        //Input.mosePosition
        //transform.Translate
        //transform.Rotate
        //transform.position
        //Vector3 구조체
    }

    void Update()
    { 
       
    // 표창스와이프해서 이동시키기 
    //1. 화면을 누른다
    //2. 드래그
    //3. 화면에서 손을 뗀다
    //4. 방향확인후 이동 

    //스와이프 화면 감지 => 아래서 위로 
    //bool isBottomDown = Input.GetMouseButtonDown(0); // 하단
    //bool isToptDown = Input.GetMouseButtonDown(3); // 상단
   
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Input.mousePosition);
            speed += 0.96f;

        }
        else if (Input.GetMouseButtonUp(3))
        {
          //  speed += bottom;
            Debug.Log(Input.mousePosition);
        }
        this.transform.Rotate(0, speed, 0);
        Debug.Log(speed);


    }
}
