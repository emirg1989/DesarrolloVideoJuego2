using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class InputViewMediator : EventMediator {

    [Inject]
    public InputView view { get; set; }

   override public void OnRegister()
    {
        view.dispatcher.AddListener(GameEvents.ON_LEFT, onLeft);
        view.dispatcher.AddListener(GameEvents.ON_MOVE, onMove);
        view.dispatcher.AddListener(GameEvents.ON_RIGHT, onRight);
    }

   override public void OnRemove()
    {
        view.dispatcher.RemoveListener
                (GameEvents.ON_LEFT, onLeft);
        view.dispatcher.RemoveListener(GameEvents.ON_MOVE, onMove);
        view.dispatcher.RemoveListener(GameEvents.ON_RIGHT, onRight);
    }

    void onLeft()
    {
        dispatcher.Dispatch(GameEvents.ON_LEFT);
    }
    void onMove()
    {
        dispatcher.Dispatch(GameEvents.ON_MOVE);
    }

    void onRight()
    {
        dispatcher.Dispatch(GameEvents.ON_RIGHT);
    }
}
