using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class ItemViewMediator : EventMediator {
	[Inject]
	public ItemView itemView{ get; set;}

	override public void OnRegister()
	{

		itemView.dispatcher.AddListener (GameEvents.ON_TOUCH_ME, onTouchMe);
	}

	override public void OnRemove()
	{
		itemView.dispatcher.RemoveListener (GameEvents.ON_TOUCH_ME, onTouchMe);
	}

	void onTouchMe()
	{
		dispatcher.Dispatch (GameEvents.ON_TOUCH_ME, itemView.gameObject.name);
	}

}
