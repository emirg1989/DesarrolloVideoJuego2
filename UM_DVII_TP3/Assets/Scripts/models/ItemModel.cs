using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ItemModel : IItemModel {

	[PostConstruct]
	public void PostConstruct()
	{
		items = new List<GameObject> ();
	}

	#region IItemModel implementation
	public List<GameObject> items { get; set;}
	#endregion
}

