using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class TimerView : EventView {

	public float playtime;

	internal void Update()
	{
		dispatcher.Dispatch(GameEvents.ON_UPDATE, Time.time);
	}


	internal void UpdatePlayTime(float time)
	{
		playtime = time;
	}

}
