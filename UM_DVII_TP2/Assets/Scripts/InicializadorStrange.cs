using UnityEngine;
using System.Collections;
using strange.extensions.context.impl;

public class InicializadorStrange : ContextView
{

	// Use this for initialization
	void Start ()
	{
		context = new MyContextView(this);
	}

	// Update is called once per frame
	void Update () {

	}
}
