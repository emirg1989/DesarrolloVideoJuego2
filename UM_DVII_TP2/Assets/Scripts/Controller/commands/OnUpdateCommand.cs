using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;

public class OnUpdateCommand : EventCommand
{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    public GameModel gameModel { get; set; }

    override public void Execute()
    {
        Debug.Log(Time.deltaTime);
        gameModel.time += evt.data as float;
    }


}
