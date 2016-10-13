using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class NewSpeedPlayerCommand : EventCommand {

	[Inject]
	public IPlayerModel player{ get; set;}



	override public void Execute()
	{
		player.Reset ();
		string nameCollectable = (string)evt.data;
		Debug.Log (nameCollectable);

		/*
		float newSpeed = player.speed + collectableModel.amountPower;
		Debug.Log (collectableModel);
		dispatcher.Dispatch (GameEvents.ON_SET_NEW_SPEED_PLAYER, newSpeed);
*/
	}
}
