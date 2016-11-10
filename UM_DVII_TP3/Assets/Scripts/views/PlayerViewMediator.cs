using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;


public class PlayerViewMediator : EventMediator
{

    [Inject]
    public PlayerView view { get; set; }

    override public void OnRegister()
    {
        view.init();
        dispatcher.AddListener
                  (GameEvents.ON_LEFT, onViewLeft);
        dispatcher.AddListener
                  (GameEvents.ON_MOVE, onViewMove);
        dispatcher.AddListener
                 (GameEvents.ON_RIGHT, onViewRight);
        dispatcher.AddListener(GameEvents.ON_BACK, onViewBack);
		dispatcher.AddListener (GameEvents.ON_SET_NEW_SPEED_PLAYER, onUpdateSpeed);
		dispatcher.AddListener (GameEvents.ON_SAVE_WEAPON, onSaveWeapon);
		view.dispatcher.AddListener(GameEvents.ON_SPAWN_SPRITE_ITEM, onSpriteWeapon);
		view.dispatcher.AddListener(GameEvents.ON_UPDATE_POSITION_PLAYER, onUpdatePosition);
    }

    override public void OnRemove()
    {
        dispatcher.RemoveListener
                 (GameEvents.ON_LEFT, onViewLeft);
        dispatcher.RemoveListener
                  (GameEvents.ON_MOVE, onViewMove);
        dispatcher.RemoveListener
                 (GameEvents.ON_RIGHT, onViewRight);
        dispatcher.RemoveListener(GameEvents.ON_BACK, onViewBack);
		dispatcher.RemoveListener (GameEvents.ON_SET_NEW_SPEED_PLAYER, onUpdateSpeed);
		dispatcher.RemoveListener (GameEvents.ON_SAVE_WEAPON, onSaveWeapon);
		view.dispatcher.RemoveListener(GameEvents.ON_SPAWN_SPRITE_ITEM, onSpriteWeapon);
		view.dispatcher.RemoveListener(GameEvents.ON_UPDATE_POSITION_PLAYER, onUpdatePosition);
    }
   
    void onViewLeft()
    {
        view.UpdateLeft();
    }

    void onViewMove()
    {
        view.UpdateMove();
    }

    void onViewRight()
    {
        view.UpdateRight();
    }

    void onViewBack()
    {
        view.UpdateBack();
    }
	void onUpdateSpeed(IEvent evt)
	{
		float newSpeed = (float)evt.data;
		view.GetSpeed (newSpeed);
	}
	void onSaveWeapon()
	{
		view.SaveWeapon ();
	}

	void onSpriteWeapon()
	{
		dispatcher.Dispatch (GameEvents.ON_SPAWN_SPRITE_ITEM, view.nameWeapon);
	}
	void onUpdatePosition()
	{
		dispatcher.Dispatch (GameEvents.ON_UPDATE_POSITION_PLAYER, view.transform.position);
	}
}
