using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using strange.extensions.injector.api;

public class  SetEffectCollectableCommand: EventCommand {


	[Inject]
	public IPlayerModel player { get; set; }

	[Inject]
	public IWeaponModel weapon{ get; set;}

	[Inject]
	public IEnemyModel enemy { get; set; }

	override public void Execute()
	{
		string viewName = (string)evt.data;
		ICollectableModel collectableModel = injectionBinder.GetBinding(viewName).value as ICollectableModel;
		if (viewName == Utility.Collectable0) {
			player.Reset ();
			float newDamage = player.speed + collectableModel.amountPower;
			dispatcher.Dispatch (GameEvents.ON_UPDATE_NEW_SPEED_PLAYER, newDamage);
		} else if (viewName == Utility.Collectable2) {
			float newSpeed = collectableModel.amountPower;
			dispatcher.Dispatch (GameEvents.ON_UPDATE_NEW_SPEED_ENEMY, newSpeed);	
		} else if (viewName == Utility.Collectable1) {
			float newDamage = weapon.damage + collectableModel.amountPower;
			dispatcher.Dispatch (GameEvents.ON_UPDATE_NEW_DAMAGE_WEAPON,newDamage);
		}
	}
}
