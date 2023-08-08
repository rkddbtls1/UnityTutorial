using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.AI;
using JetBrains.Annotations;

public class Agent : MonoBehaviour
{
    #region �迭
    // ���� �ڷ����� ������� �̷���� ���� ����

    private int [] buffer = new int[3];

    private int count = 0 ;
    public NavMeshAgent naveMeshAgent;
    public Transform [] pointBuffer;
    #endregion
        // 
    void Start()
    {
        
        
        // �迭�� ��� ù ��° ���Ҵ� 0���� ����
        // �迭�� ���ϴ� ���ҿ� ���ϴ� ���� ������ �� ����
        // �迭�� ũ��� �������� �Ǵ� ������������
        // ������ �޸� ������ ���� ��
        for (int i = 0; i < buffer.Length; i++)
        {
            Debug.Log(buffer[i]);
        }

        // InvokeRepeating : Ư�� �ð� �� Ư�� �ð�����
        // �Լ��� �ݺ������� ȣ���ϴ� �Լ�
        InvokeRepeating(nameof(IncreaseCount), 0, 5);
    }

    public void IncreaseCount()
    {
        count++;
        count = count % pointBuffer.Length;
    }
    
    void Update()
    {
        naveMeshAgent.SetDestination(pointBuffer[count].position);
    }
}
