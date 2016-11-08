using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class OnUseItemCommand : EventCommand {

	override public void Execute()
	{
		string viewName = (string)evt.data;
		dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, viewName);
	}
}
