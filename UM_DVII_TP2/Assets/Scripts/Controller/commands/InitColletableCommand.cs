using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;
using System.Collections.Generic;

public class InitColletableCommand : EventCommand {

	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
		for (int i = 0; i < 3; i++) 
		{
			ICollectableModel collectableModel = injectionBinder.GetInstance<ICollectableModel>();
			if (i == 0) 
			{
	
				collectableModel.amountPower = 30f;


			} else if (i == 1) 
			{
				collectableModel.amountPower = 5f;
				
			} else 
			{
				collectableModel.amountPower = 20f;
			}

			string collectableName = Utility.Collectable + i;
			GameObject goCollectable = GameObject.Instantiate(Resources.Load(collectableName)) as GameObject;
			goCollectable.name = collectableName;
			goCollectable.AddComponent<CollectableView>();
			goCollectable.transform.parent = contextView.transform;
			injectionBinder.Bind(collectableName).To(collectableModel);	
		}
	}

}
