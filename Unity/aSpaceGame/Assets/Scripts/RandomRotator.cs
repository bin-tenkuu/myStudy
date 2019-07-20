using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
	public float tumble;

	private Rigidbody rb;

	private void Start() {
		this.rb = this.GetComponent<Rigidbody>();
		this.rb.angularVelocity = Random.insideUnitSphere * this.tumble;
	}
}
