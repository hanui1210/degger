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
