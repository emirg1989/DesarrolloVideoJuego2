using UnityEngine;
using System.Collections;
using System;

public class PlayerModel : IPlayerModel
{
	[PostConstruct]
	public void PostConstruct()
	{
		speed = 10f;
		life = 50f;
		haveWeapon = false;
	}
    public float speed { get; set; }
	public float life{ get; set;}
	public bool haveWeapon{ get; set;}
	public Vector3 playerPosition{ get; set;}
}
