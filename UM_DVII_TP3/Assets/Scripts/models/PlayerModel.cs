using UnityEngine;
using System.Collections;
using System;

public class PlayerModel : IPlayerModel
{
	[PostConstruct]
	public void PostConstruct()
	{
		speed = 50f;

	}

    public float speed { get; set; }

}
