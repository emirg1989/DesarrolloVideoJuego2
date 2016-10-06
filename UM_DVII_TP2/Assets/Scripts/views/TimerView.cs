using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class TimerView : EventView {

	private const int DISABLE = 0;
	private const int time = 1;
	public int playtime;
	internal string player = "Player";
	internal string enemy = "Enemy";
	internal string timer0 = "Timer0";
	internal string timer1 = "Timer1";
	internal string playTimer = "PlayTimer";

	internal void Init()
	{
		StartCoroutine(playTimer);
	}

	private IEnumerator PlayTimer()
	{
		while (true)
		{
			yield return new WaitForSeconds(1);
			playtime -= time;
			if (playtime == DISABLE)
			{
				if (this.gameObject.name == timer0) 
				{
					dispatcher.Dispatch (GameEvents.ON_RESTORE_STATS, player);
					this.Stop ();
				}
				if (this.gameObject.name == timer1) 
				{
					dispatcher.Dispatch (GameEvents.ON_RESTORE_STATS,enemy);
					this.Stop ();
				}
			}
				//dispatcher.Dispatch(GameEvents.ON_GAME_OVER);
		}
	}

	public void SetPlayTime(int time)
	{
		playtime = time;

	}

	private void Stop()
	{
		StopCoroutine(playTimer);
		Destroy (this.gameObject);
	}

}
