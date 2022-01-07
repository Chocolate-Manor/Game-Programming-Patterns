using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandlerWithActor : MonoBehaviour
{
    [SerializeField] private CommandWithActor W;
    [SerializeField] private CommandWithActor A;
    [SerializeField] private CommandWithActor S;
    [SerializeField] private CommandWithActor D;

    public CommandWithActor HandleInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            return W;
        }
                
        if (Input.GetKey(KeyCode.S))
        {
            return S;
        }
            
        if (Input.GetKey(KeyCode.A))
        {
            return A;
        }
            
        if (Input.GetKey(KeyCode.D))
        {
            return D;
        }

        return null;
    }
}
