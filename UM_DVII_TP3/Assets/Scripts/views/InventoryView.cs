﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using strange.extensions.mediation.impl;
using UnityEngine.UI;

public class InventoryView : EventView {


	public List<SlotView> slotsView = new List<SlotView>();

	internal string nameChild;

	internal void OpenInventory(bool flag)
	{
		this.gameObject.SetActive (flag);

	}
		
	internal void FocusSlot(int pos)
	{
		for (int i = 0; i < slotsView.Count ; i++) 
		{
			if (i == pos)
			{
				slotsView [i].Paint ();
				if (slotsView [i].gameObject.transform.childCount!=0) {
					nameChild = slotsView [i].gameObject.transform.GetChild (0).name;
					dispatcher.Dispatch (GameEvents.ON_TOUCH_ME, nameChild);
				}
			}
		}
	}

	internal void AddSlotView(SlotView slot)
	{
		slotsView.Add (slot);
	}
}
