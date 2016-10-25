using UnityEngine;
using System.Collections;
using System;

public class PlayerModel : IPlayerModel
{
    public void Reset()
    {
        speed = 50f;
    }

    public float speed { get; set; }

}
