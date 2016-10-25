using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class EnemyViewMediator : EventMediator {

	[Inject]
	public EnemyView view { get; set; }

	override public void OnRegister()
	{
		dispatcher.AddListener (GameEvents.ON_SET_NEW_SPEED_ENEMY, onUpdateSpeed);
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_SET_NEW_SPEED_ENEMY, onUpdateSpeed);
	}

	void onUpdateSpeed(IEvent evt)
	{
		float newSpeed = (float)evt.data;
		view.GetSpeed (newSpeed);
	}

}
