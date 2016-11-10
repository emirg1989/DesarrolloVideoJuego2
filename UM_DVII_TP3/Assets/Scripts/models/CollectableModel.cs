using UnityEngine;
using System.Collections;

public class CollectableModel : ICollectableModel,ISaveable {

	#region ISaveable implementation
	public bool saveInInventory{ get; set; }
	#endregion

	public float amountPower{ get; set; }
	public string eventCollectable{ get; set;}
	public string nameSpriteCollectable{ get; set;}
	public string name{ get; set;}
}
