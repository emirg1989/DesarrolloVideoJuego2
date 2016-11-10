using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class WeaponView : EventView {

	public float damage;

	internal void UpdateDamage(float damageReceive)
	{
		damage += damageReceive;
	} 
}
