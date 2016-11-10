using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class OnGrapCollectable : EventCommand {

	override public void Execute()
	{
		string nameCollectable = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding (nameCollectable).value as ICollectableModel;

		if (model.saveInInventory) 
		{
			dispatcher.Dispatch (GameEvents.ON_SPAWN_SPRITE_ITEM, nameCollectable);
		} 
		else if(!model.saveInInventory) 
		{
			dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, nameCollectable);		
		}
	}
}
