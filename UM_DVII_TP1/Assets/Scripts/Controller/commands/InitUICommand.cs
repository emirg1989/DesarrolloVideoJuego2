using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitUICommand : EventCommand {

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    [Inject]
    public IPlayerModel player { get; set; }

    [Inject]
    public IGameModel game { get; set; }

    override public void Execute()
    {
        GameObject go = new GameObject();
        go.name = Utility.UI;
        go.AddComponent<UIView>();
        UIView uiView = go.GetComponent<UIView>();
        uiView.init();
        game.ResetTime();
        player.Reset();
        uiView.SetScore(player.score);
        uiView.SetTime(game.time);
        go.transform.parent = contextView.transform;
    }
}
