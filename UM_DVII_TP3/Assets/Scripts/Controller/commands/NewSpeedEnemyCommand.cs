using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class NewSpeedEnemyCommand : EventCommand {

	[Inject]
	public IEnemyModel enemy{ get; set;}

	override public void Execute()
	{
		string nameCollectable = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding (nameCollectable).value as ICollectableModel;
		float newSpeed = enemy.speed + model.amountPower;
		dispatcher.Dispatch (GameEvents.ON_SET_NEW_SPEED_ENEMY, newSpeed);
	}
}
