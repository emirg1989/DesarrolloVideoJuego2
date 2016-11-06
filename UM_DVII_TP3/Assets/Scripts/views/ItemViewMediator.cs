using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class ItemViewMediator : EventMediator {
	[Inject]
	public ItemView itemView{ get; set;}

	override public void OnRegister()
	{
		itemView.dispatcher.AddListener (GameEvents.ON_SET_EFFECT_COLLECTABLE, onSetEffect);
	}

	override public void OnRemove()
	{
		itemView.dispatcher.RemoveListener (GameEvents.ON_SET_EFFECT_COLLECTABLE, onSetEffect);
	}

	void onSetEffect()
	{
		dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, itemView.gameObject.name);
	}

}
