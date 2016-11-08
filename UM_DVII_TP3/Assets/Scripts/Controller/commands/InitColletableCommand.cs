using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;

using System;
using SimpleJSON;



public class InitColletableCommand : EventCommand
{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    override public void Execute()
	{
		//cargamos el archivo collectable.json y lo devolvemos como un text
		TextAsset file = Resources.Load ("Collectable") as TextAsset;
		//parseamos ese file.text
		var n = SimpleJSON.JSON.Parse (file.text);
		//recorremos variable n y asignamos los valores
		for (int i = 0; i < n ["collectibles"].Count; i++) {
			ICollectableModel collectableModel = injectionBinder.GetInstance<ICollectableModel> ();
			collectableModel.name = n ["collectibles"] [i] ["name"].Value;
			collectableModel.amountPower = n ["collectibles"] [i] ["amount"].AsFloat;
			collectableModel.eventCollectable = n ["collectibles"] [i] ["event"];
			collectableModel.nameSpriteCollectable =  n ["collectibles"] [i] ["sprite"].Value;
			GameObject goCollectable = GameObject.Instantiate (Resources.Load (collectableModel.name)) as GameObject;
			goCollectable.name = collectableModel.name;
			goCollectable.AddComponent<CollectableView> ();
			goCollectable.transform.parent = contextView.transform;
			injectionBinder.Bind(collectableModel.name).To(collectableModel);					
		}
	}
}