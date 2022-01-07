using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCommand :Command 
{


    public override void Execute(GameObject gameObject)
    {
        //Debug.Log("Left");
        gameObject.transform.position += Vector3.left * 5 * Time.deltaTime;
    }
}
