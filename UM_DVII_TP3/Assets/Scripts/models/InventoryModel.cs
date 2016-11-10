using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InventoryModel : IInventoryModel {

	[PostConstruct]
	public void PostConstruct()
	{
		slots = new List<GameObject> ();

	}

	public List<GameObject>slots { get; set;}


}
