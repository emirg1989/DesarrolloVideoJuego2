using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class PlayerView : EventView {

    public float speedPlayer;
    Rigidbody rb;
	internal string nameWeapon;

   internal void init()
    {
        rb = GetComponent<Rigidbody>();
    }
    internal void UpdateLeft()
    {
		this.move (1, 0, 0);
		dispatcher.Dispatch (GameEvents.ON_UPDATE_POSITION_PLAYER, this.transform.position);
    }
    internal void UpdateMove()
    {
		this.move (0, 0, -1);
		dispatcher.Dispatch (GameEvents.ON_UPDATE_POSITION_PLAYER, this.transform.position);
    }

    internal void UpdateRight()
    {
		this.move (-1, 0, 0);
		dispatcher.Dispatch (GameEvents.ON_UPDATE_POSITION_PLAYER, this.transform.position);
    }
    internal void UpdateBack()
    {
		this.move (0, 0, 1);
		dispatcher.Dispatch (GameEvents.ON_UPDATE_POSITION_PLAYER, this.transform.position);
    }

    public void GetSpeed(float speed)
    {
        speedPlayer  = speed;
    }

	internal void SaveWeapon()
	{
		GameObject child = this.transform.GetChild (0).gameObject;
		nameWeapon = child.name;
		Destroy (child);
		dispatcher.Dispatch (GameEvents.ON_SPAWN_SPRITE_ITEM, nameWeapon);
	}

	private void move(float x, float y, float z)
	{
		Vector3 movement = new Vector3(x,y,z);
		rb.velocity = movement * speedPlayer;
	}
}
