using System;
using strange.extensions.dispatcher.eventdispatcher.api;
using strange.extensions.mediation.impl;


public class UIViewMediator : EventMediator
{
    [Inject]
   public UIView view { get; set; }

    public override void OnRegister()
    {
        dispatcher.AddListener(GameEvents.ON_GAME_OVER,onGameOver);
        dispatcher.AddListener(GameEvents.ON_UPDATE_TIME, onUpdateTimeView);  
    }


    public override void OnRemove()
    {
        dispatcher.RemoveListener(GameEvents.ON_GAME_OVER, onGameOver);
        dispatcher.RemoveListener(GameEvents.ON_UPDATE_TIME, onUpdateTimeView);

    }

    void onGameOver()
    {
        view.gameOver();
    }

    void onUpdateTimeView(IEvent evt)
    {
        int time = (int)evt.data;
        view.UpdateTime(time);
    }
}
