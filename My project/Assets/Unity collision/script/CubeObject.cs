using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObject : MonoBehaviour
{

    // OnCollisionEnter: �浹 �߻�������

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("�浹�� �߻��Ͽ����ϴ�.");
    }

    // OnCollisionStay(Collision collision) �浹 ���� ��

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("�浹 ���Դϴ�.");
    }

    // OnCollisionExit: �浹�� ���� �� ��

    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("�浹���� ������ϴ�. ����ȣ��!");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger �浹 �߻�");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger �浹 ��");

        }
    }

    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.name == "Main Cube")
        {
            Debug.Log("Trigger �浹 ����");

        }
    }
}
