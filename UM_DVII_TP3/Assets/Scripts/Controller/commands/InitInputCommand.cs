using UnityEngine;
using System.Collections;
using strange.extensions.context.api;
using strange.extensions.command.impl;

public class InitInputCommand : EventCommand {

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }

    [Inject]
    public IPlayerModel player { get; set; }

    override public void Execute()
    {
        GameObject go = new GameObject();
        go.name = Utility.Input;
        go.AddComponent<InputView>();
        go.transform.parent = contextView.transform;
    }
}
