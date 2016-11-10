using UnityEngine;
using System.Collections;
using strange.extensions.mediation.impl;

public class SlotViewMediator : EventMediator {

	[Inject]
	public SlotView view { get; set;}
}
