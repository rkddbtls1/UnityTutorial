using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{

    // OnCollisionEnter: 충돌 발생했을때

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("충돌이 발생하였습니다.");
    }

    // OnCollisionStay(Collision collision) 충돌 중일 때

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("충돌 중입니다.");
    }

    // OnCollisionExit: 충돌을 벗어 날 때

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("충돌에서 벗어났습니다. 끼얏호우!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger 충돌 발생");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger 충돌 중");

        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger 충돌 종료");

        }
    }
}
