using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class CollectableView : EventView {

 	internal string nameCollectable0 = "Collectable0";
	internal string nameCollectable1 = "Collectable1";
	internal string nameCollectable2 = "Collectable2";
	internal string nameTimer0 = "Timer0";
	internal string nameTimer1 = "Timer1";

	void OnTriggerEnter(Collider co){
	
		if (this.gameObject.name == nameCollectable0) {
			dispatcher.Dispatch (GameEvents.ON_INIT_TIMER, nameTimer0);
			dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, nameCollectable0);
			this.DestroyObject ();
		} else if (this.gameObject.name == nameCollectable1) {
			dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, nameCollectable1);
			this.DestroyObject ();
		} else if(this.gameObject.name == nameCollectable2){
			dispatcher.Dispatch (GameEvents.ON_SET_EFFECT_COLLECTABLE, nameCollectable2);
			dispatcher.Dispatch (GameEvents.ON_INIT_TIMER, nameTimer1);
			this.DestroyObject ();
		}
	}

	private void DestroyObject()
	{
		Destroy (this.gameObject);
	}

}
