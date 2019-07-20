using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SimpleTouchAreaButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

	private bool touched;
	private int pointerID;
	private bool canFire;

	private void Awake() {
		this.touched = false;
	}

	/// <summary>
	/// set our start point
	/// </summary>
	/// <param name="eventData"></param>
	public void OnPointerDown(PointerEventData eventData) {
		if (!this.touched) {
			this.touched = true;
			this.pointerID = eventData.pointerId;
			this.canFire = true;
		}
	}
	/// <summary>
	/// reset everything
	/// </summary>
	/// <param name="eventData"></param>
	public void OnPointerUp(PointerEventData eventData) {
		if (eventData.pointerId == this.pointerID) {
			this.canFire = false;
			this.touched = false;
		}
	}

	public bool CanFire() {
		return this.canFire;
	}
}