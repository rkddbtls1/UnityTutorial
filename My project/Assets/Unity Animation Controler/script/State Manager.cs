using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StateManager : MonoBehaviour
{
    private Animator Animator = null;

    private void Start()
    {
        Animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Animator.SetTrigger("Fast Run");        
        }
    }
}
