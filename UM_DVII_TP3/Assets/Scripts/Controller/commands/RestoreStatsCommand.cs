using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class RestoreStatsCommand : EventCommand {
	
	[Inject]
	public IPlayerModel player { get; set; }

	override public void Execute()
	{
		string nameGameObject = (string)evt.data;
		if (nameGameObject == Utility.Player) {
			player.Reset ();
			dispatcher.Dispatch (GameEvents.ON_UPDATE_NEW_SPEED_PLAYER, player.speed);
		} else if (nameGameObject == Utility.Enemy) {
			IEnemyModel enemyModel = injectionBinder.GetInstance<IEnemyModel>();
			enemyModel.speed = 60f;
			dispatcher.Dispatch (GameEvents.ON_UPDATE_NEW_SPEED_ENEMY, enemyModel.speed);
		}
	}
}
