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
			string nameCollectible = n ["collectibles"] [i] ["name"].Value;
			collectableModel.amountPower = n ["collectibles"] [i] ["amount"].AsFloat;
			string gameEvent = n ["collectibles"] [i] ["event"];
			GameObject goCollectable = GameObject.Instantiate (Resources.Load (nameCollectible)) as GameObject;
			goCollectable.name = nameCollectible;
			goCollectable.AddComponent<CollectableView> ();
			goCollectable.transform.parent = contextView.transform;
			injectionBinder.Bind(nameCollectible).To(gameEvent);					
		}
	}
}