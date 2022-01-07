using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActor : MonoBehaviour
{
    [SerializeField]
    private float speed;

    public float getSpeed()
    {
        return speed;
    }
}
