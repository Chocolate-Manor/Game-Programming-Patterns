using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DownCommandWithActor : CommandWithActor
{
    public override void Execute(GameActor actor)
    {
        actor.gameObject.transform.position += Vector3.down * actor.getSpeed() * Time.deltaTime;
    }
}
