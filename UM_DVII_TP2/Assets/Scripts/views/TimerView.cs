using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class TimerView : EventView {

	public int playtime;
	private int count;



	internal void Update()
	{
		dispatcher.Dispatch(GameEvents.ON_UPDATE, Time.deltaTime);

	}


	internal void UpdatePlayTime(int time)
	{
		playtime = time;
	}

}
