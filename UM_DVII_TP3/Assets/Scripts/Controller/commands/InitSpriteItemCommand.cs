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

	override public void Execute()
	{
		
		string viewName = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding(viewName).value as ICollectableModel;
		for (int i = 0; i < inventory.slots.Count; i++) 
		{
			if (inventory.slots[i].transform.childCount == 0)
			{
				// lo hagas una vez al principio y guardes la referencia al GameObject en un modelo
				// para no tener que cargar de nuevo todas las veces que agarres un collectable
				GameObject goItem = GameObject.Instantiate (Resources.Load ("Item")) as GameObject;
				goItem.name = model.name;
				// esto tambien
				goItem.GetComponent<Image> ().sprite = Resources.Load<Sprite> (model.nameSpriteCollectable);
				goItem.transform.SetParent (inventory.slots[i].transform, false);
				goItem.transform.localPosition = Vector3.zero;
				break;
			}
		}
	}
}
