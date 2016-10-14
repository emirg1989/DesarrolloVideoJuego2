using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class TimerViewMediator : EventMediator {

	[Inject]
	public TimerView view{ get; set;}

	override public void OnRegister()
	{
		view.dispatcher.AddListener (GameEvents.ON_UPDATE, onInitTime);
			dispatcher.AddListener (GameEvents.ON_UPDATE_TIME, onUpdateTime);
	}

	override public void OnRemove()
	{
		view.dispatcher.RemoveListener (GameEvents.ON_UPDATE, onInitTime);
		dispatcher.RemoveListener (GameEvents.ON_UPDATE_TIME, onUpdateTime);

	}
		
	private void onUpdateTime(IEvent evt)
	{
		int newTime = (int)evt.data;
		view.UpdatePlayTime (newTime);
	} 
	private void onInitTime(){
		dispatcher.Dispatch (GameEvents.ON_UPDATE, Time.time);
	}
}
