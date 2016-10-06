using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;
using strange.extensions.dispatcher.eventdispatcher.api;

public class PlayerView : EventView {

    public float speedPlayer;
    Rigidbody rb;

   internal void init()
    {
        rb = GetComponent<Rigidbody>();
    }
    internal void UpdateLeft()
    {
        rb.AddForce(new Vector3(1,0,0) *speedPlayer,ForceMode.Force);
    }
    internal void UpdateMove()
    {
        rb.AddForce(new Vector3(0, 0, -1) * speedPlayer, ForceMode.Force);
    }

    internal void UpdateRight()
    {
        rb.AddForce(new Vector3(-1, 0, 0) * speedPlayer, ForceMode.Force);
    }
    internal void UpdateBack()
    {
        rb.AddForce(new Vector3(0, 0, 1) * speedPlayer, ForceMode.Force);
    }

    public void GetSpeed(float speed)
    {
        speedPlayer  = speed;
    }
}
