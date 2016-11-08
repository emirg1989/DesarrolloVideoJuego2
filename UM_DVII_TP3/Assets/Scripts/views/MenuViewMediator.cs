using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class MenuViewMediator : EventMediator {

	[Inject]
	public MenuView menuView{ get; set;}

	override public void OnRegister()
	{
		menuView.Init ();
		dispatcher.AddListener (GameEvents.ON_TOUCH_ME, onTouchMe);
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_TOUCH_ME, onTouchMe);
	}

	void onTouchMe()
	{
		menuView.Show ();
	}
}
