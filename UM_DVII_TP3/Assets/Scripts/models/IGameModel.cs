using UnityEngine;
using System.Collections;

public interface IGameModel {

	float time { get; set; }
    void ResetTime();
}
