using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class CollectableViewMediator : EventMediator {

	[Inject]
	public CollectableView view { get; set; }

	override public void OnRegister()
	{
		view.dispatcher.AddListener (GameEvents.ON_INIT_TIMER, onInitTimer);
		view.dispatcher.AddListener (GameEvents.ON_SET_EFFECT_COLLECTABLE, onSetEffectCollectable);
	}
	override public void OnRemove()
	{
		view.dispatcher.RemoveListener (GameEvents.ON_INIT_TIMER, onInitTimer);
		view.dispatcher.RemoveListener (GameEvents.ON_SET_EFFECT_COLLECTABLE, onSetEffectCollectable);
	}

	void onInitTimer(IEvent evt)
	{
		if (evt.data == view.nameTimer0) {
			dispatcher.Dispatch (GameEvents.ON_INIT_TIMER, view.nameTimer0);
		} else {
			dispatcher.Dispatch (GameEvents.ON_INIT_TIMER,view.nameTimer1);	
		}
	}

	void onSetEffectCollectable(IEvent evt)
	{
		if (evt.data == view.nameCollectable0) {
			dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, view.nameCollectable0);
		} else if (evt.data == view.nameCollectable1) {
			dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, view.nameCollectable1);
		} else if(evt.data == view.nameCollectable2)
		{
			dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, view.nameCollectable2);
		}
	}
}
