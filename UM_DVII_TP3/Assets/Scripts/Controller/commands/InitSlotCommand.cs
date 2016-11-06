using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitSlotCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }



	override public void Execute()
	{
		for(int i= 0; i < 6 ; i++)
		{
			GameObject goSlot = GameObject.Instantiate(Resources.Load("Slot")) as GameObject;
			goSlot.name = "Slot";
			goSlot.AddComponent<SlotView> ();
			goSlot.transform.SetParent(contextView.transform.FindChild("HUD").FindChild("Inventory").transform, false);
			dispatcher.Dispatch (GameEvents.ON_ADD_SLOT, goSlot);
		}
	}
}
