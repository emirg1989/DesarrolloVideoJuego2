using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class TimerViewMediator : EventMediator {
    
	[Inject]
    public TimerView view { get; set; }

    override public void OnRegister()
    {
		view.dispatcher.AddListener(GameEvents.ON_GAME_OVER, onGameOver);
        view.dispatcher.AddListener(GameEvents.ON_UPDATE_TIME, onUpdateTime);
        dispatcher.Dispatch(GameEvents.ON_UPDATE_TIME, view.playtime);
    }

    override public void OnRemove()
    {
        view.dispatcher.RemoveListener(GameEvents.ON_MOVE, onGameOver);
        view.dispatcher.RemoveListener(GameEvents.ON_UPDATE_TIME, onUpdateTime);


    }

    void onGameOver()
    {
        dispatcher.Dispatch(GameEvents.ON_GAME_OVER);
    }

    void onUpdateTime(IEvent evt)
    {
        dispatcher.Dispatch(GameEvents.ON_UPDATE_TIME, evt.data);
    }
    
}