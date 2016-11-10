using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class OnDiscardItemCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	[Inject]
	public IPlayerModel player{ get; set;}

	override public void Execute()
	{
		string nameItem = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding(nameItem).value as ICollectableModel;
		GameObject goCollectable = GameObject.Instantiate (Resources.Load (model.name)) as GameObject;
		goCollectable.name = model.name;
		goCollectable.AddComponent<CollectableView> ();
		goCollectable.transform.parent = contextView.transform;
		goCollectable.transform.localPosition = player.playerPosition - new Vector3(0f,0.5f,0f) + Vector3.back;
	}
}
