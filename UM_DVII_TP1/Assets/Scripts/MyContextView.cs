using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;

public class MyContextView : MVCSContext {

    public MyContextView(MonoBehaviour view) : base(view) { }

    override protected void mapBindings()
    {
        commandBinder.Bind(ContextEvent.START).To<InitGameCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_ESCENARY).To<InitEscenaryCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_UI).To<InitUICommand>();
        commandBinder.Bind(GameEvents.ON_INIT_PLAYER).To<InitPlayerCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_INPUT).To<InitInputCommand>();
		commandBinder.Bind (GameEvents.ON_INIT_TIMER).To<InitTimerCommand> ();
	
        mediationBinder.Bind<PlayerView>().To<PlayerViewMediator>();
        mediationBinder.Bind<TimerView>().To<TimerViewMediator>();
        mediationBinder.Bind<InputView>().To<InputViewMediator>();
        mediationBinder.Bind<UIView>().To<UIViewMediator>();
        injectionBinder.Bind<IPlayerModel>().To<PlayerModel>();
        injectionBinder.Bind<IGameModel>().To<GameModel>();
    }
}
