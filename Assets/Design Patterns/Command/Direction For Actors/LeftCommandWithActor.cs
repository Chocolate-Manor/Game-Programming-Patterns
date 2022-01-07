using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftCommandWithActor :CommandWithActor
{
    public override void Execute(GameActor actor)
    {
        actor.gameObject.transform.position += Vector3.left * actor.getSpeed() * Time.deltaTime;
    }
}
