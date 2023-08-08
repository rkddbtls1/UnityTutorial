using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.AI;
using JetBrains.Annotations;

public class Agent : MonoBehaviour
{
    #region 배열
    // 같은 자료형의 변수들로 이루어진 유한 집합

    private int [] buffer = new int[3];

    private int count = 0 ;
    public NavMeshAgent naveMeshAgent;
    public Transform [] pointBuffer;
    #endregion
        // 
    void Start()
    {
        
        
        // 배열의 경우 첫 번째 원소는 0부터 시작
        // 배열은 원하는 원소에 원하는 값을 저장할 수 있음
        // 배열으 크기는 컴파일이 되는 시점에서부터
        // 고정된 메모리 공간을 갖게 됨
        for (int i = 0; i < buffer.Length; i++)
        {
            Debug.Log(buffer[i]);
        }

        // InvokeRepeating : 특정 시간 후 특정 시간마다
        // 함수를 반복적으로 호출하는 함수
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
