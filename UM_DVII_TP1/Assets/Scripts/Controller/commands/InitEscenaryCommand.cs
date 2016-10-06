using UnityEngine;
using System.Collections;
using strange.extensions.command.impl;
using strange.extensions.context.api;

public class InitEscenaryCommand: EventCommand{

    [Inject(ContextKeys.CONTEXT_VIEW)]
    public GameObject contextView { get; set; }


    override public void Execute()
    {
        GameObject goEscenary = GameObject.Instantiate(Resources.Load(Utility.Escenary)) as GameObject;
        goEscenary.name = Utility.Escenary;
        goEscenary.transform.parent = contextView.transform;
    }
}

