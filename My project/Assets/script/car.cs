using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class car : MonoBehaviour
{
    // ���ؽ���    ����ִ�
    // ���ؽ���    ����ִ�

    char character = 'A';
    int integer = 100;
    float pi = 3.141592f;

    string name = "Sonata";

    private void Start()
    {

        character = 'B';
        integer = 123;
        pi = 3.142f;
        name = "ppap";

           

        Debug.Log("character ������ ��" + character);
        Debug.Log(integer);
        Debug.Log(pi);
        Debug.Log(name);
            
    }
}