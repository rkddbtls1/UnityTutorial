using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class car : MonoBehaviour
{
    // 엄준식은    살아있다
    // 엄준식은    살아있다

    #region 함수
    //하나의 특별한 목적의 작업을 수행하기 위해
    //독립적으로 설계된 코드의 집함

    private void Stop()
    {
        Debug.Log("정지");
    }

    private void Update()
    {
        // 조건문이란 어떤 조건이 주어질 때
        // 해당 조건에 따라 동작을 시행하게 하는 명령문재인

        // if문은 어떤 특정한 조건을 비교해
        // 조건이 맞으면 실행되는 명령문

        // GetkeyDown : 키 누르면 반응
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Stop();
        }
        else if(Input.GetKeyDown(KeyCode.Q)) 
        {
            Debug.Log("핸들 조정");
        }
        else
        {
            Debug.Log("시동 꺼짐");
        }
        // else if는 if 조건이 틀릴 때
        // else if가 맞다면 실행됨
    }
    #endregion
    //

    char character = 'A';
    public int integer = 100;
    private float pi = 3.141592f;

    string name = "Sonata";

    private void Start()
    {

        character = 'B';
        pi = 3.142f;
        name = "ppap";

           

        Debug.Log("character 변수의 값" + character);
        Debug.Log(integer);
        Debug.Log(pi);
        Debug.Log(name);
            
    }
}