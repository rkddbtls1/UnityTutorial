
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

        // Input.Getxis() : 매개변수 호라이즌을 넣으면
        // x 좌표에 대한 정보 -1~1 사이의 값을 반환하는 함수
        // 호라이즌탈: 수평 / 버티칼 앞뒤

        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(x, 0, z);

        // 벡터의 정규화씨

        direction.Normalize();
        transform.Translate(new Vector3(x, 0, z) * Speed * Time.deltaTime);
        
        
        // float y = Input.GetAxis("Um still allive");

        // v = v0 + vt

        // transform.position: 자신의 위치
        // vector3.forward = new Vector(0,0,1);

        // Time.deltaTime : 프레임이 완료되기까지 걸리는 시간

        // Debug.Log(Time.deltaTime);
        // transform.position += Vector3.forward * Speed * Time.deltaTime;

    }
}
