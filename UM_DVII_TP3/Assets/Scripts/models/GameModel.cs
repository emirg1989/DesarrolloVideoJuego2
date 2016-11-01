using UnityEngine;
using System.Collections;

public class GameModel : IGameModel
{

	[PostConstruct]
	public void PostConstruct()
	{
		time = 0;

	}
	public float time { get; set; }
}
