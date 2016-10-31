using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using UnityEngine.UI;
using strange.extensions.context.api;
using System.Collections.Generic;

public class InitSpriteItemCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	[Inject]
	public IInventoryModel inventory{ get; set;}

	[Inject]
	public IItemModel itemsList{ get; set;}

	override public void Execute()
	{
		string viewName = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding(viewName).value as ICollectableModel;
		Debug.Log (inventory.slots.Count);
			for (int i = 0; i < inventory.slots.Count; i++) {
				GameObject goItem = GameObject.Instantiate (Resources.Load ("Item")) as GameObject;
				goItem.name = model.nameSpriteCollectable;
				goItem.GetComponent<Image> ().sprite = Resources.Load<Sprite> (model.nameSpriteCollectable);
				goItem.transform.SetParent (contextView.transform.FindChild ("HUD").FindChild ("Inventory").FindChild ("Slot" + i).transform);
				goItem.transform.position = Vector2.zero;
				break;
			}
	}
}
