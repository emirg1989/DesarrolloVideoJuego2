using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class UpdatePositionPlayer : EventCommand {

	[Inject]
	public IPlayerModel player{ get; set;}

	override public void Execute()
	{
		Vector3 position = (Vector3)evt.data;
		player.playerPosition = position;
	}
}
