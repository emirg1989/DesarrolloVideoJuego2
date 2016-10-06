using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class TimerView : EventView {

    private const int GAMEOVER = 0;
    private const int time = 1;
    public int playtime;

    internal void Init()
    {
        StartCoroutine("PlayTimer");
    }

    private IEnumerator PlayTimer()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            playtime -= time;
            dispatcher.Dispatch(GameEvents.ON_UPDATE_TIME, playtime);
            if (playtime == GAMEOVER)
            {
                dispatcher.Dispatch(GameEvents.ON_GAME_OVER);
                StopCoroutine("PlayTimer");
            }
        }
    }

    public void SetPlayTime(int time)
    {
            playtime = time;
        
    }
   
}
