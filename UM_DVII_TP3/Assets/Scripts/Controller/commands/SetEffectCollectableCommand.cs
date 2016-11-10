using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.injector.api;

public class SetEffectCollectableCommand : EventCommand
{
	
    override public void Execute()
    {
        string viewName = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding(viewName).value as ICollectableModel;
		dispatcher.Dispatch(model.eventCollectable,viewName);
    }
}
