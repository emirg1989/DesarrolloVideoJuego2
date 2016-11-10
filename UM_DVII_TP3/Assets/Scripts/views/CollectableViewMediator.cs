using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class CollectableViewMediator : EventMediator {

	[Inject]
	public CollectableView view { get; set; }

	override public void OnRegister()
	{
		view.dispatcher.AddListener (GameEvents.ON_GRAP_COLLECTABLE, OnGrapItem);
	}
	override public void OnRemove()
	{
		view.dispatcher.RemoveListener (GameEvents.ON_GRAP_COLLECTABLE, OnGrapItem);
	}


	void OnGrapItem()
	{
		dispatcher.Dispatch (GameEvents.ON_GRAP_COLLECTABLE, view.gameObject.name);
	}
}
