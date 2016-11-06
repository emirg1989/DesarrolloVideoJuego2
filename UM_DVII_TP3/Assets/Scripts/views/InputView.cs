using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;


public class InputView: EventView
{  
	internal int pos;

    void Update()
    {
            if (Input.GetKey(KeyCode.A))
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
            if (Input.GetKey(KeyCode.S))
            {
                dispatcher.Dispatch(GameEvents.ON_BACK);
            }
			if (Input.GetKeyUp (KeyCode.I)) 
			{
			dispatcher.Dispatch (GameEvents.ON_TOUCH_I);
			}
			if (Input.GetKeyUp (KeyCode.Alpha1)) 
			{
				pos = 0;
				dispatcher.Dispatch (GameEvents.ON_TOUCH_NUM, pos);
			}
			if (Input.GetKeyUp (KeyCode.Alpha2)) 
			{
				pos = 1;
				dispatcher.Dispatch (GameEvents.ON_TOUCH_NUM, pos);
			}
			if (Input.GetKeyUp (KeyCode.Alpha3)) 
			{
				pos = 2;
				dispatcher.Dispatch (GameEvents.ON_TOUCH_NUM, pos);
			}
			if (Input.GetKeyUp (KeyCode.Alpha4)) 
			{
				pos = 3;
				dispatcher.Dispatch (GameEvents.ON_TOUCH_NUM, pos);
			}
			if (Input.GetKeyUp (KeyCode.Alpha5)) 
			{
				pos = 4;
				dispatcher.Dispatch (GameEvents.ON_TOUCH_NUM, pos);
			}
			if (Input.GetKeyUp (KeyCode.Alpha6)) 
			{
				pos = 5;
				dispatcher.Dispatch (GameEvents.ON_TOUCH_NUM, pos);
			}
    }
}
