using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class ItemView : EventView {

	public void ShowMenu()
	{
		dispatcher.Dispatch (GameEvents.ON_TOUCH_ME, this.gameObject.name);
	}
}
