using UnityEngine;
using System.Collections;
using System;

public class PlayerModel : IPlayerModel
{
    public void Reset()
    {
        score = 2;
    }

    public int score { get; set; }
}
