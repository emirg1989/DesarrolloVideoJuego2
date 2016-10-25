using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class OnInitInventaryCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }


	override public void Execute()
	{
		GameObject goInventary =  GameObject.Instantiate(Resources.Load("Inventory")) as GameObject;
		goInventary.name = "HUD";
		goInventary.transform.FindChild("Inventory").gameObject.AddComponent<InventoryView>();
		goInventary.transform.parent = contextView.transform;
		dispatcher.Dispatch (GameEvents.ON_INIT_SLOT);
	}
}
