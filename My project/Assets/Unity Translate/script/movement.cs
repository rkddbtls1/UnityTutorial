
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float Speed = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        // Input.Getxis() : �Ű����� ȣ�������� ������
        // x ��ǥ�� ���� ���� -1~1 ������ ���� ��ȯ�ϴ� �Լ�
        // ȣ������Ż: ���� / ��ƼĮ �յ�

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        // ������ ����ȭ��

        direction.Normalize();
        transform.Translate(new Vector3(x, 0, z) * Speed * Time.deltaTime);
        
        
        // float y = Input.GetAxis("Um still allive");

        // v = v0 + vt

        // transform.position: �ڽ��� ��ġ
        // vector3.forward = new Vector(0,0,1);

        // Time.deltaTime : �������� �Ϸ�Ǳ���� �ɸ��� �ð�

        // Debug.Log(Time.deltaTime);
        // transform.position += Vector3.forward * Speed * Time.deltaTime;

    }
}
