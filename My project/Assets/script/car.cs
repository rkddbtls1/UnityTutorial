using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;


public class car : MonoBehaviour
{
    // ���ؽ���    ����ִ�
    // ���ؽ���    ����ִ�

    #region �Լ�
    //�ϳ��� Ư���� ������ �۾��� �����ϱ� ����
    //���������� ����� �ڵ��� ����

    private void Stop()
    {
        Debug.Log("����");
    }

    private void Update()
    {
        // ���ǹ��̶� � ������ �־��� ��
        // �ش� ���ǿ� ���� ������ �����ϰ� �ϴ� ��ɹ�����

        // if���� � Ư���� ������ ����
        // ������ ������ ����Ǵ� ��ɹ�

        // GetkeyDown : Ű ������ ����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Stop();
        }
        else if(Input.GetKeyDown(KeyCode.Q)) 
        {
            Debug.Log("�ڵ� ����");
        }
        else
        {
            Debug.Log("�õ� ����");
        }
        // else if�� if ������ Ʋ�� ��
        // else if�� �´ٸ� �����
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

           

        Debug.Log("character ������ ��" + character);
        Debug.Log(integer);
        Debug.Log(pi);
        Debug.Log(name);
            
    }
}