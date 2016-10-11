using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class TimerView : EventView {

	public int playtime;
	private int count;



	internal void Update()
	{
		//Debug.Log(Time.time);
	}
		

	internal void UpdatePlayTime(int time)
	{
		playtime = time;
	}
		
}
