using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class PlayerView : EventView {


    internal void UpdateLeft()
    {
        Debug.Log("left");
    }
    internal void UpdateMove()
    {
        Debug.Log("move");
    }

    internal void UpdateRight()
    {
        Debug.Log("Right");
    }
}
