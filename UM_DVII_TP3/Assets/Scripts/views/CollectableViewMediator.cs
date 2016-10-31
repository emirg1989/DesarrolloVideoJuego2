﻿using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class CollectableViewMediator : EventMediator {

	[Inject]
	public CollectableView view { get; set; }

	override public void OnRegister()
	{
		view.dispatcher.AddListener (GameEvents.ON_SPAWN_SPRITE_ITEM, onSpawnSpriteItem);
	}
	override public void OnRemove()
	{
		view.dispatcher.RemoveListener (GameEvents.ON_SPAWN_SPRITE_ITEM, onSpawnSpriteItem);
	}


	void onSpawnSpriteItem()
	{
		
		dispatcher.Dispatch (GameEvents.ON_SPAWN_SPRITE_ITEM, view.gameObject.name);
	}
}
