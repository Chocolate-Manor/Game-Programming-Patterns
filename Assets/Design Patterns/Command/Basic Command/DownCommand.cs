using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCommand :Command 
{
    public override void Execute(GameObject gameObject)
    {
        gameObject.transform.position += Vector3.down * 5 * Time.deltaTime;
    }
}
