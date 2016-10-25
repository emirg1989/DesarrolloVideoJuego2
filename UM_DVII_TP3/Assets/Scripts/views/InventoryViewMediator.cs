using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class InventoryViewMediator : EventMediator {

	[Inject]
	public InventoryView view { get; set; }

	override public void OnRegister()
	{
		view.Init ();
		dispatcher.AddListener(GameEvents.ON_TOUCH_I, onTouchI);
		dispatcher.AddListener (GameEvents.ON_ADD_SLOT, onAddSlot);

	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener(GameEvents.ON_TOUCH_I, onTouchI);
		dispatcher.RemoveListener (GameEvents.ON_ADD_SLOT, onAddSlot);

	}

	void onTouchI()
	{
		if (view.flag) {
			view.Init ();
		} else {
			view.OpenInventory ();
		}
	}

	void onAddSlot(IEvent evt)
	{
		GameObject slot = evt.data as GameObject;
		view.addSlot (slot);
	}
}
