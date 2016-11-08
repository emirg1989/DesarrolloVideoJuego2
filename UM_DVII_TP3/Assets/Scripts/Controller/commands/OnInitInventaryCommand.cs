using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;

public class OnInitInventaryCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	[Inject]
	public IInventoryModel inventoryModel{ get; set;}

	override public void Execute()
	{
		GameObject goInventary =  GameObject.Instantiate(Resources.Load("Inventory")) as GameObject;
		goInventary.name = "HUD";
		goInventary.transform.FindChild("Inventory").gameObject.AddComponent<InventoryView>();
		InventoryView inventory = goInventary.transform.FindChild("Inventory").gameObject.GetComponent<InventoryView> ();
		goInventary.transform.SetParent(contextView.transform, false);
		for(int i= 0; i < 6 ; i++)
		{
			GameObject goSlot = GameObject.Instantiate(Resources.Load("Slot")) as GameObject;
			goSlot.name = "Slot" + i;
			goSlot.AddComponent<SlotView> ();
			SlotView slot = goSlot.GetComponent<SlotView>();
			goSlot.transform.SetParent(contextView.transform.FindChild("HUD").FindChild("Inventory").transform, false);
			inventory.AddSlotView (slot);
			inventoryModel.slots.Add (goSlot);
		}
	}
}
