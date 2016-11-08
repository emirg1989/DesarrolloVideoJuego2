using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitWeaponCommand : EventCommand
{
	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	override public void Execute()
	{
		string nameCollectable = (string)evt.data;
		ICollectableModel model = injectionBinder.GetBinding(nameCollectable).value as ICollectableModel;
		GameObject goWeapon = GameObject.Instantiate (Resources.Load (model.name)) as GameObject;
		goWeapon.name = model.name;
		goWeapon.AddComponent<WeaponView>();
		WeaponView weaponView = goWeapon.GetComponent<WeaponView> ();
		weaponView.UpdateDamage (model.amountPower);
		goWeapon.transform.SetParent( contextView.GetComponentInChildren<PlayerView>().transform);
		goWeapon.transform.localPosition = Vector3.right;
		dispatcher.Dispatch (GameEvents.ON_SET_DAMAGE_WEAPON, model.amountPower);
	}
}
