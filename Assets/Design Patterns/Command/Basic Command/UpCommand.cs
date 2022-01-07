using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCommand : Command
{
     public override void Execute(GameObject gameObject)
    {
        gameObject.transform.position += Vector3.up * 5 * Time.deltaTime;
    }
}
