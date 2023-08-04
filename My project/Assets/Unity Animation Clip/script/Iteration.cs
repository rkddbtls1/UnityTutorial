using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Iteration : MonoBehaviour
{
    // #region 반복문
    // 프로그램 내의 특정한 작업을 반복적으로 수행함

    private void Start()
    {
        // for 문
        // 조건식의 결과에 따라 특정 횟수만큼 작업을 반복

        // 1. int i가 0임
        for(int i = 0; i< 5; i++)
        {
            Debug.Log("1");
        }
    }



}
