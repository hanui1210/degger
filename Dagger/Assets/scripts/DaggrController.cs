using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class daggerContlloer : MonoBehaviour
{
    private float speed = 0;
    
    void Start()
    {
        // ���� ���� Ȱ��
        //Input.GetMouseButtonDown
        //Input.GetMouseButtonUp
        //Input.mosePosition
        //transform.Translate
        //transform.Rotate
        //transform.position
        //Vector3 ����ü
    }

    void Update()
    { 
       
    // ǥâ���������ؼ� �̵���Ű�� 
    //1. ȭ���� ������
    //2. �巡��
    //3. ȭ�鿡�� ���� ����
    //4. ����Ȯ���� �̵� 

    //�������� ȭ�� ���� => �Ʒ��� ���� 
    //bool isBottomDown = Input.GetMouseButtonDown(0); // �ϴ�
    //bool isToptDown = Input.GetMouseButtonDown(3); // ���
   
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
