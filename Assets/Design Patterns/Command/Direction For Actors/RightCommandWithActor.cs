using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCommandWithActor : CommandWithActor 
{
    public override void Execute(GameActor actor)
    {
        actor.gameObject.transform.position += Vector3.right * actor.getSpeed() * Time.deltaTime;
    }
}
