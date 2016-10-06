using UnityEngine;
using System.Collections;

public class GameModel : IGameModel {

    public void ResetTime()
    {
        time = 10;
    }
	public int time { get; set; }
}
