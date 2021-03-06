﻿using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class CollectableView : EventView {

	void OnTriggerEnter(Collider co){
		dispatcher.Dispatch (GameEvents.ON_GRAP_COLLECTABLE, this.gameObject.name);
		Destroy (this.gameObject);
	}
}
