using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;


public class PlayerViewMediator : EventMediator
{

    [Inject]
    public PlayerView view { get; set; }

    override public void OnRegister()
    {
        dispatcher.AddListener
                  (GameEvents.ON_LEFT, onViewLeft);
        dispatcher.AddListener
                  (GameEvents.ON_MOVE, onViewMove);
        dispatcher.AddListener
                 (GameEvents.ON_RIGHT, onViewRight);
    }

    override public void OnRemove()
    {
        dispatcher.RemoveListener
                 (GameEvents.ON_LEFT, onViewLeft);
        dispatcher.RemoveListener
                  (GameEvents.ON_MOVE, onViewMove);
        dispatcher.RemoveListener
                 (GameEvents.ON_RIGHT, onViewRight);
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
    
}
