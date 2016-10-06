using UnityEngine;
using System.Collections;

public interface IGameModel {

    int time { get; set; }
    void ResetTime();
}
