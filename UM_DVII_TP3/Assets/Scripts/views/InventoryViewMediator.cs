using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class InventoryViewMediator : EventMediator {

	[Inject]
	public InventoryView view { get; set; }

	private bool flag;

	override public void OnRegister()
	{
		view.OpenInventory (flag);
		dispatcher.AddListener(GameEvents.ON_TOUCH_I, onTouchI);
		dispatcher.AddListener(GameEvents.ON_TOUCH_NUM, onTouchNum);
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener(GameEvents.ON_TOUCH_I, onTouchI);
		dispatcher.RemoveListener(GameEvents.ON_TOUCH_NUM, onTouchNum);
	}

	void onTouchI()
	{
		flag = !flag;
		view.OpenInventory (flag);
	}
	void onTouchNum(IEvent evt)
	{
		int pos = (int)evt.data;
		view.FocusSlot (pos);
	}
		
}
