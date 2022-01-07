using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// I know I should just use an interface, but i just want to hammer in the protected virtual knowledge.
/// So this is protected and virtual. Heh. Well abstract is implicitly virtual. 
/// Abstract class allows you to create functionality that subclasses can implement or override.
///
/// Also Abstract class methods is also a strict contract.
///
///
///Really what this does is to abstract specific commands into a general COMMAND that can be executed.
///Thus we can assign that COMMAND to any implemented command. 
///
/// 
/// </summary>
public abstract class Command : MonoBehaviour
{
    //An abstract method is implicitly a virtual method. 
    /// <summary>
    /// An abstract method doesn't need to declare a body. 
    /// </summary>
    public abstract void Execute(GameObject gameObject);
}
