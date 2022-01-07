using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    [SerializeField] private Command W;
    [SerializeField] private Command A;
    [SerializeField] private Command S;
    [SerializeField] private Command D;

    private void Update()
    {
       HandleInput(); 
    }

    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            W.Execute(gameObject);
        }
                
        if (Input.GetKey(KeyCode.S))
        {
            S.Execute(gameObject);
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            A.Execute(gameObject);
        }
            
        if (Input.GetKey(KeyCode.D))
        {
            D.Execute(gameObject);
        }
    }
}
