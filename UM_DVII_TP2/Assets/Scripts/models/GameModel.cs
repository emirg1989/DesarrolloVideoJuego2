using UnityEngine;
using System.Collections;

public class GameModel : IGameModel
{

    public void ResetTime()
    {
        time = 0;
    }
    public int time { get; set; }
}
