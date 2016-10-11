using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class UpdateModelTimerCommand : EventCommand {

	[Inject]
	public ITimerModel timerModel { get; set; }

	override public void Execute()
	{
		int newTime = (int)evt.data;
		timerModel.time = newTime;
		dispatcher.Dispatch (GameEvents.ON_UPDATE_TIME, timerModel.time);
	}
}
