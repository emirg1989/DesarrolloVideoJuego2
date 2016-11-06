using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitPlayerCommand : EventCommand{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    [Inject]
    public IPlayerModel player { get; set; }

    override public void Execute()
    {
        //instanciamos el player
        GameObject goPlayer = GameObject.Instantiate(Resources.Load(Utility.Player)) as GameObject;
        goPlayer.name = Utility.Player;
        goPlayer.AddComponent<PlayerView>();
        PlayerView playerView = goPlayer.GetComponent<PlayerView>();
        playerView.GetSpeed(player.speed);
		goPlayer.transform.parent = contextView.transform;
		dispatcher.Dispatch (GameEvents.ON_INIT_WEAPON);
    }
}
