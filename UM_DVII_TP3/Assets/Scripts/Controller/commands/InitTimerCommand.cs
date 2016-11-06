using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitTimerCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
		GameObject goTimer = GameObject.Instantiate(Resources.Load("Timer")) as GameObject;
		goTimer.name = "Timer";
		goTimer.AddComponent<TimerView>();
		goTimer.transform.parent = contextView.transform;
	}
}
