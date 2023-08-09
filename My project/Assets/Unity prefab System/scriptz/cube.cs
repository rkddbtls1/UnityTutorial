using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public float speed = 5.0f;

    void Update()
    {
        transform.Rotate(speed * Time.deltaTime, speed * Time.deltaTime, 0);
    }
}
