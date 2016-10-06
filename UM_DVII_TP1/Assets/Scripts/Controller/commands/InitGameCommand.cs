using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitGameCommand : EventCommand {

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    override public void Execute()
    {
        dispatcher.Dispatch(GameEvents.ON_INIT_ESCENARY);
        dispatcher.Dispatch(GameEvents.ON_INIT_PLAYER);
        dispatcher.Dispatch(GameEvents.ON_INIT_UI);
        dispatcher.Dispatch(GameEvents.ON_INIT_INPUT);
		dispatcher.Dispatch (GameEvents.ON_INIT_TIMER);
    }
}
