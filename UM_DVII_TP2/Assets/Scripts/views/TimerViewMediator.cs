using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class TimerViewMediator : EventMediator {

	[Inject]
	public TimerView view{ get; set;}

	override public void OnRegister()
	{
		view.Init ();
		view.dispatcher.AddListener (GameEvents.ON_RESTORE_STATS, onRestoreStats);
	}

	override public void OnRemove()
	{
		view.dispatcher.RemoveListener (GameEvents.ON_RESTORE_STATS, onRestoreStats);
	}

	void onRestoreStats(IEvent evt)
	{
		if (evt.data == view.player) {
			dispatcher.Dispatch (GameEvents.ON_RESTORE_STATS, view.player);
		} else {
			dispatcher.Dispatch (GameEvents.ON_RESTORE_STATS, view.enemy);
		}

	}
		
}
