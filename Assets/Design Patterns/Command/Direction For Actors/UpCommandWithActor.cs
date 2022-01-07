using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpCommandWithActor : CommandWithActor 
{


    public override void Execute(GameActor actor)
    {
        actor.gameObject.transform.position += Vector3.up * actor.getSpeed() * Time.deltaTime;
    }
}
