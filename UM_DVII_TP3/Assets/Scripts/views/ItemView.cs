using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class ItemView : EventView {

	public void ShowMenu()
	{
		dispatcher.Dispatch (GameEvents.ON_TOUCH_ME, this.gameObject);
	}

	internal void DestroyItem(string nameItem)
	{
		/*
		if (nameItem == this.gameObject.name) 
		{
			Destroy (this.gameObject);
		}
		*/
	}
}
