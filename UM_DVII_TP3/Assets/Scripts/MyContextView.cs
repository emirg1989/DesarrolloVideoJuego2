using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;
using strange.extensions.context.api;

public class MyContextView : MVCSContext
{

    public MyContextView(MonoBehaviour view) : base(view) { }

    override protected void mapBindings()
    {
        commandBinder.Bind(ContextEvent.START).To<InitGameCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_ESCENARY).To<InitEscenaryCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_PLAYER).To<InitPlayerCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_INPUT).To<InitInputCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_ENEMIES).To<InitEnemyCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_COLLECTABLE).To<InitColletableCommand>();
        commandBinder.Bind(GameEvents.ON_SET_EFFECT_COLLECTABLE).To<SetEffectCollectableCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_WEAPON).To<InitWeaponCommand>();
        commandBinder.Bind(GameEvents.ON_INIT_TIMER).To<InitTimerCommand>();
        commandBinder.Bind(GameEvents.ON_RESTORE_STATS).To<RestoreStatsCommand>();
        commandBinder.Bind(GameEvents.ON_UPDATE_MODEL_TIMER).To<UpdateModelTimerCommand>();
        commandBinder.Bind(GameEvents.ON_UPDATE).To<OnUpdateCommand>();
		commandBinder.Bind (GameEvents.ON_UPDATE_NEW_SPEED_PLAYER).To<NewSpeedPlayerCommand>();
		commandBinder.Bind (GameEvents.ON_UPDATE_NEW_SPEED_ENEMY).To<NewSpeedEnemyCommand> ();
		commandBinder.Bind (GameEvents.ON_UPDATE_NEW_DAMAGE_WEAPON).To<NewDamageWeaponCommand> ();
		commandBinder.Bind (GameEvents.ON_INIT_INVENTARY).To<OnInitInventaryCommand> ();
		commandBinder.Bind (GameEvents.ON_SPAWN_SPRITE_ITEM).To<InitSpriteItemCommand> ();
		commandBinder.Bind (GameEvents.ON_USE_ITEM).To<OnUseItemCommand> ();
		commandBinder.Bind (GameEvents.ON_INCREMENT_LIFE_PLAYER).To<IncrementLifePlayer> ();

        mediationBinder.Bind<PlayerView>().To<PlayerViewMediator>();
        mediationBinder.Bind<TimerView>().To<TimerViewMediator>();
        mediationBinder.Bind<WeaponView>().To<WeaponViewMediator>();
        mediationBinder.Bind<EnemyView>().To<EnemyViewMediator>();
        mediationBinder.Bind<InputView>().To<InputViewMediator>();
        mediationBinder.Bind<CollectableView>().To<CollectableViewMediator>();
		mediationBinder.Bind<InventoryView> ().To<InventoryViewMediator> ();
		mediationBinder.Bind<SlotView>().To<SlotViewMediator> ();
		mediationBinder.Bind<ItemView>().To<ItemViewMediator> ();
		mediationBinder.Bind<MenuView> ().To<MenuViewMediator> ();

		injectionBinder.Bind<IPlayerModel>().To<PlayerModel>().ToSingleton();
		injectionBinder.Bind<ITimerModel>().To<TimerModel>().ToSingleton();
		injectionBinder.Bind<IGameModel>().To<GameModel>().ToSingleton();
		injectionBinder.Bind<IEnemyModel> ().To<EnemyModel> ();
		injectionBinder.Bind<ICollectableModel> ().To<CollectableModel> ();
		injectionBinder.Bind<IWeaponModel>().To<WeaponModel>().ToSingleton();
		injectionBinder.Bind<IInventoryModel> ().To<InventoryModel> ().ToSingleton();
		injectionBinder.Bind<IItemModel> ().To<ItemModel> ().ToSingleton();
    }
}
