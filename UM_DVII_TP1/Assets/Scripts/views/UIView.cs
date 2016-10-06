using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using System;
using strange.extensions.dispatcher.eventdispatcher.api;

public class UIView : View
{
    [Inject]
    public IEventDispatcher dispatcher { get; set; }



    private const string SCORE = "score: ";
    private const string TIMER = "time: ";
    private const string GAMEOVER = "GameOver";
    private Rect scoreRect;
    private string scoreString;
    private string timeString;
    private Rect gameOverRect;
    private bool gameFlag;

    internal void init()
    {
        scoreRect = new Rect(5f, 5f, 120f, 50f);
        gameOverRect = new Rect(Screen.width / 2f, Screen.height / 2f, 100f, 100f);
        gameFlag = true;
    }

    private void OnGUI()
    {
        GUI.TextField(scoreRect, scoreString + "\n" + timeString);
        if (!gameFlag) {
            GUI.TextField(gameOverRect, GAMEOVER);
        }
    }

    internal void SetScore(int score)
    {
        scoreString = SCORE + score.ToString();
    }
    internal void SetTime(int time)
    {
        timeString = TIMER + time.ToString();
    }

    internal void gameOver()
    {
        gameFlag = false;
    }

    internal void UpdateTime(int time)
    {
        timeString = TIMER + time.ToString();
    }
}
