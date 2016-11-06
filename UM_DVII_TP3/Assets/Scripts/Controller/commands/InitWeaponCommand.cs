using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitWeaponCommand : EventCommand
{
	[Inject(ContextKeys.CONTEXT_VIEW)]
	public GameObject contextView { get; set; }

	[Inject]
	public IWeaponModel weapon{ get; set;}

	override public void Execute()
	{
		GameObject goWeapon = GameObject.Instantiate (Resources.Load (Utility.Weapon)) as GameObject;
		goWeapon.name = Utility.Weapon;
		goWeapon.AddComponent<WeaponView>();
		WeaponView weaponView = goWeapon.GetComponent<WeaponView> ();
		weaponView.UpdateDamage (weapon.damage);
		goWeapon.transform.parent = contextView.GetComponentInChildren<PlayerView>().transform;
		dispatcher.Dispatch (GameEvents.ON_SET_DAMAGE_WEAPON, weapon.damage);
	}
}
