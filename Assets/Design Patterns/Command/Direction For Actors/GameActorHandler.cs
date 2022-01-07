using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameActorHandler : MonoBehaviour
{
    [SerializeField] private GameActor gameActor;
    [SerializeField] private InputHandlerWithActor inputHandlerWithActor;

    // Update is called once per frame
    void Update()
    {
        CommandWithActor cwa = inputHandlerWithActor.HandleInput();
        if (cwa)
        {
            cwa.Execute(gameActor);
        }
    }

}
