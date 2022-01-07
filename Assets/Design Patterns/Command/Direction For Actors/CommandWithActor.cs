using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Was interface, but then interface doesn't show up in unity inspector..
/// So I am just using abstract class now. Who knew. It works better.
/// Also it needs to inherit MonoBehavior. There's no other way.
public abstract class CommandWithActor : MonoBehaviour
{
    public abstract void Execute(GameActor actor);
}
