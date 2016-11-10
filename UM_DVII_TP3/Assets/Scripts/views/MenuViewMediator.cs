using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class MenuViewMediator : EventMediator {

	[Inject]
	public MenuView menuView{ get; set;}

	override public void OnRegister()
	{
		menuView.Init ();
		dispatcher.AddListener (GameEvents.ON_TOUCH_ME, onTouchMe);
		menuView.dispatcher.AddListener (GameEvents.ON_USE_ITEM, onUseItem);
		menuView.dispatcher.AddListener (GameEvents.ON_DESTROY_ITEM, onDestroyItem);
		menuView.dispatcher.AddListener (GameEvents.ON_TOUCH_DESECHAR, onDesechar);
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_TOUCH_ME, onTouchMe);
		menuView.dispatcher.RemoveListener (GameEvents.ON_USE_ITEM, onUseItem);
		menuView.dispatcher.RemoveListener (GameEvents.ON_DESTROY_ITEM, onDestroyItem);
		menuView.dispatcher.RemoveListener (GameEvents.ON_TOUCH_DESECHAR, onDesechar);
	}

	void onTouchMe(IEvent evt)
	{
		string name = (string) evt.data;
		menuView.Show (name);
	}

	void onUseItem()
	{
		dispatcher.Dispatch (GameEvents.ON_USE_ITEM, menuView.name);
	}

	void onDestroyItem()
	{
		dispatcher.Dispatch (GameEvents.ON_DESTROY_ITEM, menuView.name);
	}
	void onDesechar()
	{
		dispatcher.Dispatch (GameEvents.ON_TOUCH_DESECHAR, menuView.name);
	}
}
