using UnityEngine;
using System.Collections;

public class WeaponModel : IWeaponModel
{	
	[PostConstruct]
	public void PostConstruct()
	{
		damage = 100f;

	}
	public float damage{ get; set;}
}
