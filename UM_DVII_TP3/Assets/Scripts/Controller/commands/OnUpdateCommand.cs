﻿using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;

public class OnUpdateCommand : EventCommand
{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

	[Inject]
	public IGameModel gameModel { get; set; }

    override public void Execute()
    {
		float newTime = (float)evt.data;
		//Debug.Log (newTime);
		gameModel.time += newTime;
    }
}
