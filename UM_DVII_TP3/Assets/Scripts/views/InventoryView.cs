using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine.UI;

public class InventoryView : EventView {

	internal bool flag;
	public List<GameObject> slots = new List<GameObject>();

	internal void Init()
	{
		this.gameObject.SetActive (false);
		flag = false;
	}

	internal void OpenInventory()
	{
		this.gameObject.SetActive (true);
		flag = true;
	}


	internal void focusSlot()
	{
		
	}

	internal void addSlot(GameObject slot)
	{
		slots.Add (slot);
	}

}
