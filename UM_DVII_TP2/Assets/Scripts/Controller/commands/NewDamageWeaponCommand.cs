using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;

public class NewDamageWeaponCommand : EventCommand {

	[Inject]
	public IWeaponModel modelW{ get; set;}



	override public void Execute()
	{
		string nameCollectable = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding(nameCollectable).value as ICollectableModel;
		float newDamage = modelW.damage + model.amountPower;
		dispatcher.Dispatch (GameEvents.ON_SET_NEW_DAMAGE_WEAPON, newDamage);

	}
}
