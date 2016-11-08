using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class MenuView : EventView {

	internal bool flag;
	internal string name;

	internal void Init()
	{
		this.gameObject.SetActive (flag);
	}
	internal void Show(string nameCollectable)
	{
		name = nameCollectable;
		this.gameObject.SetActive (!flag);
	}

	public void OnTouchUtilizar()
	{
		dispatcher.Dispatch (GameEvents.ON_USE_ITEM, name);
		this.gameObject.SetActive (flag);
	}
	public void OnTouchEliminar()
	{
		
	}

}
