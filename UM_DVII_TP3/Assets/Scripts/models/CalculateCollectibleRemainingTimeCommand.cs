using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class CalculateCollectibleRemainingTimeCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	public GameModel gameModel { get; set; }

	override public void Execute()
	{
		gameModel.time -= (int)evt.data;
	}

}
