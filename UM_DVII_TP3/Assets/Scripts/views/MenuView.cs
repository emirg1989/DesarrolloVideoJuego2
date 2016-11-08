using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class MenuView : EventView {


	internal void Init()
	{
		this.gameObject.SetActive (false);
	}
	internal void Show()
	{
		this.gameObject.SetActive (true);
	}

}
