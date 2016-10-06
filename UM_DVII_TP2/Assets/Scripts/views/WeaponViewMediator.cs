using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class WeaponViewMediator : EventMediator {

	[Inject]
	public WeaponView view{ get; set;}

	override public void OnRegister()
	{
		
		dispatcher.AddListener (GameEvents.ON_UPDATE_NEW_DAMAGE_WEAPON, onUpdateDamage);
	
	}

	override public void OnRemove()
	{
		dispatcher.RemoveListener (GameEvents.ON_UPDATE_NEW_DAMAGE_WEAPON, onUpdateDamage);
	}

	void onUpdateDamage(IEvent evt)
	{
		float newDamage = (float)evt.data;
		view.UpdateDamage (newDamage);
	}
}
