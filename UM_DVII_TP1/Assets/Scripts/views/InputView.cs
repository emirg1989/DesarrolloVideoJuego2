using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;


public class InputView: EventView
{  
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.A))
            {
                dispatcher.Dispatch(GameEvents.ON_LEFT);
            }
            if (Input.GetKey(KeyCode.W))
            {
                dispatcher.Dispatch(GameEvents.ON_MOVE);
            }
            if (Input.GetKey(KeyCode.D))
            {
                dispatcher.Dispatch(GameEvents.ON_RIGHT);
            }
        
    }
}
