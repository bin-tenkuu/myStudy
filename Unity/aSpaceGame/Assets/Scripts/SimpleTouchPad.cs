using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SimpleTouchPad : MonoBehaviour, IPointerDownHandler, IDragHandler, IPointerUpHandler {

	public float smoothing;

	private Vector2 origin;
	private Vector2 direction;
	private Vector2 smothingDirection;
	private bool touched;
	private int pointerID;

	private void Awake() {
		this.direction = Vector2.zero;
	}

	/// <summary>
	/// compare the different betwen start and current pointer position
	/// </summary>
	/// <param name="eventData"></param>
	public void OnDrag(PointerEventData eventData) {
		if (eventData.pointerId == this.pointerID) {
			Vector2 currentpoint = eventData.position;
			Vector2 directionRaw = currentpoint - this.origin;
			this.direction = directionRaw.normalized;
		}
	}
	/// <summary>
	/// set our start point
	/// </summary>
	/// <param name="eventData"></param>
	public void OnPointerDown(PointerEventData eventData) {
		if (!this.touched) {
			this.touched = true;
			this.pointerID = eventData.pointerId;
			this.origin = eventData.position;
		}
	}
	/// <summary>
	/// reset everything
	/// </summary>
	/// <param name="eventData"></param>
	public void OnPointerUp(PointerEventData eventData) {
		if (eventData.pointerId == this.pointerID) {
			this.direction = Vector2.zero;
			this.touched = false;
		}
	}

	public Vector2 GetDirection() {
		this.smothingDirection = Vector2.MoveTowards(this.smothingDirection, this.direction, this.smoothing);
		return this.smothingDirection;
	}
}