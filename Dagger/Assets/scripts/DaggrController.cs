using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class daggerContlloer : MonoBehaviour
{
    private float speed = 0;
    private float move = 0;
    
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
        transform.position += new Vector3(0,move,0);
        

        if (Input.GetMouseButtonDown(0))
        {
         //   Debug.Log(Input.mousePosition);
            speed =20;
            move += 0.1f;
           

        }
        else if (Input.GetMouseButtonUp(0))
        {
            speed =-20;
          //  speed += bottom;
          //  Debug.Log(Input.mousePosition);
        }
            this.transform.Rotate(speed,0,0);
        
       Debug.Log(speed);


    }
}
