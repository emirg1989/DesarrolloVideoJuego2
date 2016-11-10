using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class ItemView : EventView {

	public void ShowMenu()
	{
		dispatcher.Dispatch (GameEvents.ON_TOUCH_ME, this.gameObject.name);
	}

	public void DestroyItem(string nameItem)
	{

		if (nameItem == this.gameObject.name)
		{
			Destroy (this.gameObject);
		}
		
	}
	public void discard()
	{
		Destroy (this.gameObject);
		dispatcher.Dispatch (GameEvents.ON_TOUCH_DESECHAR, this.gameObject.name);
	}
}
