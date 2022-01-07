using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCommand : Command 
{

    public override void Execute(GameObject gameObject)
    {
        gameObject.transform.position += Vector3.right * 5 * Time.deltaTime;
    }
}
