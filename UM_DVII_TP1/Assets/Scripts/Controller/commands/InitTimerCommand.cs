using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;



    public class InitTimerCommand : EventCommand
    {
 
    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    [Inject]
    public IPlayerModel player { get; set; }
 
   [Inject]
    public IGameModel game { get; set; }


    override public void Execute()
    {
        GameObject go = new GameObject();
        go.name = Utility.Timer;
        go.AddComponent<TimerView>();
        TimerView timer = go.GetComponent<TimerView>();
        timer.Init();
        game.ResetTime();
        timer.SetPlayTime(game.time);
        go.transform.parent = contextView.transform;
    }
 }
	

