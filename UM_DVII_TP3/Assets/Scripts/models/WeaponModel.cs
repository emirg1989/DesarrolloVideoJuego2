using UnityEngine;
using System.Collections;

public class WeaponModel : IWeaponModel
{	
	public void Reset()
	{
		damage = 100;
	}
	public float damage{ get; set;}
}
