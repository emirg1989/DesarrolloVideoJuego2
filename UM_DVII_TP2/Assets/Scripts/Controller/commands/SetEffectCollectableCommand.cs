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

		// empiezo a escuchar el ON_UPDATE para en otro command
		// poder calcular el tiempo restante a partir de ahora
		//	model.timeRemaining = model.duration;
		//	Debug.Log (model.timeRemaining);
		//commandBinder.Bind(GameEvents.ON_UPDATE).To<CalculateCollectibleRemainingTimeCommand>();

			//******* CalculateCollectibleRemainingTime
			//restarle el DeltaTime al collectableModel.timeRemaining
			//y si es cero, disparas el evento para terminar el efecto del collectible

    }
}
