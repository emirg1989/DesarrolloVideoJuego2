using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitTimerCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
			ITimerModel timerModel = injectionBinder.GetInstance<ITimerModel> ();
			string timerName = (string)evt.data;
			GameObject goTimer = GameObject.Instantiate(Resources.Load(timerName)) as GameObject;
			goTimer.name = timerName;
			goTimer.AddComponent<TimerView>();
			TimerView timer = goTimer.GetComponent<TimerView> ();
			if (timerName == Utility.Timer0) {
				timerModel.time = 30;
			} else {
				timerModel.time = 15;
			}
			timer.SetPlayTime (timerModel.time);
			goTimer.transform.parent = contextView.transform;
			injectionBinder.Bind(timerName).To(timerModel);

	}
}
