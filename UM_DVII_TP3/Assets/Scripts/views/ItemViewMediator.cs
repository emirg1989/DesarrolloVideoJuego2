using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class ItemViewMediator : EventMediator {
	[Inject]
	public ItemView itemView{ get; set;}

	override public void OnRegister()
	{
		itemView.dispatcher.AddListener (GameEvents.ON_TOUCH_ME, onTouchMe);
		dispatcher.AddListener (GameEvents.ON_DESTROY_ITEM, onDestroyItem);
	}

	override public void OnRemove()
	{
		itemView.dispatcher.RemoveListener (GameEvents.ON_TOUCH_ME, onTouchMe);
		dispatcher.RemoveListener (GameEvents.ON_DESTROY_ITEM, onDestroyItem);
	}

	void onTouchMe()
	{
		dispatcher.Dispatch (GameEvents.ON_TOUCH_ME, itemView.gameObject.name);
	}

	void onDestroyItem(IEvent evt)
	{
		string nameItem = (string)evt.data;
		itemView.DestroyItem (nameItem);
	}

}
