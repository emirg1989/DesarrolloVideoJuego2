using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class CollectableViewMediator : EventMediator {

	[Inject]
	public CollectableView view { get; set; }

	override public void OnRegister()
	{
		view.dispatcher.AddListener (GameEvents.ON_SET_EFFECT_COLLECTABLE, onSetEffectCollectable);
	}
	override public void OnRemove()
	{
		view.dispatcher.RemoveListener (GameEvents.ON_SET_EFFECT_COLLECTABLE, onSetEffectCollectable);
	}


	void onSetEffectCollectable()
	{
		
		dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, view.gameObject.name);
	}
}
