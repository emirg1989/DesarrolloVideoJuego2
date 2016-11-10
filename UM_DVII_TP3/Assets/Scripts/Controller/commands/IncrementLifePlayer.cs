using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class IncrementLifePlayer : EventCommand {

	[Inject]
	public IPlayerModel playerModel{ get; set;}



	override public void Execute()
	{
		string nameCollectable = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding(nameCollectable).value as ICollectableModel;
		if (playerModel.life < 100) {
			float newLife = playerModel.life + model.amountPower;
			playerModel.life += newLife;
			Debug.Log ("new life player: " + newLife);
		} else 
		{
			Debug.Log ("ya posee vida maxima el player");
		}
	}
}
