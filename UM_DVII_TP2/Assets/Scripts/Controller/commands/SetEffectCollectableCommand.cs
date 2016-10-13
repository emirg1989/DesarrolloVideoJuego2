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
		string eventName = injectionBinder.GetBinding(viewName).value.ToString();
		Debug.Log (eventName);
		dispatcher.Dispatch(eventName,viewName);
		/*
        dispatcher.Dispatch(eventName, viewName);

        
			//******* CommandCollectible0 ***
			player.Reset ();
			float newDamage = player.speed + collectableModel.amountPower;
			// empiezo a escuchar el ON_UPDATE para en otro command
			// poder calcular el tiempo restante a partir de ahora
			collectableModel.timeRemaining = collectableModel.duration;
			commandBinder.Bind(GameEvents.ON_UPDATE).To<CalculateCollectibleRemainingTime>();

			//******* CalculateCollectibleRemainingTime
			restarle el DeltaTime al collectableModel.timeRemaining
			y si es cero, disparas el evento para terminar el efecto del collectible



			//********* CommandCollectible1
			float newSpeed = collectableModel.amountPower;
			dispatcher.Dispatch (GameEvents.ON_UPDATE_MODEL_TIMER, Utility.Time2);


			//********* CommandCollectible2
			float newDamage = weapon.damage + collectableModel.amountPower;

		*/
    }
}
