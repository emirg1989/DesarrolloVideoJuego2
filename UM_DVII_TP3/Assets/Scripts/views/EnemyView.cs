using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class EnemyView : EventView {

	public float speedEnemy;

	public void GetSpeed(float speed)
	{
		speedEnemy  = speed;
	}
}
