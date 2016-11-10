using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using strange.extensions.mediation.impl;

public class SlotView : EventView {
	
	Color32 colorSlot = new Color32(199,96,3,255);	

	public void Paint() {
		StartCoroutine(PaintForSeconds());
	}

	IEnumerator PaintForSeconds() {
		this.ChangeColor (Color.blue);
		yield return new WaitForSeconds(2);
		this.ChangeColor (colorSlot);
	}

	void ChangeColor(Color32 color)
	{
		this.gameObject.GetComponent<Image> ().color = color;	
	}
}
