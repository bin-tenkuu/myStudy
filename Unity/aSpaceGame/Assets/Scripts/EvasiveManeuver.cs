using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvasiveManeuver : MonoBehaviour {
	public float dodge;
	public float smoothing;
	public float tilt;
	public Vector2 startWait;
	public Vector2 maneuverTime;
	public Vector2 maneuverWait;
	public Boundary boundary;

	private float targetManeuver;
	private float currentSpeed;
	private Rigidbody rb;

	private void Start() {
		this.rb = this.GetComponent<Rigidbody>();
		this.currentSpeed = this.rb.velocity.z;
		this.StartCoroutine(this.Evade());
	}

	private IEnumerator Evade() {
		yield return new WaitForSeconds(Random.Range(this.startWait.x, this.startWait.y));
		while (true) {
			this.targetManeuver = Random.Range(1, this.dodge) * -Mathf.Sign(this.transform.position.x);
			yield return new WaitForSeconds(Random.Range(this.maneuverTime.x, this.maneuverTime.y));
			this.targetManeuver = 0;
			yield return new WaitForSeconds(Random.Range(this.maneuverWait.x, this.maneuverWait.y));

		}
	}

	private void FixedUpdate() {
		float newManeuver = Mathf.MoveTowards(this.rb.velocity.x, this.targetManeuver, Time.deltaTime * this.smoothing);
		this.rb.velocity = new Vector3(newManeuver, 0, this.currentSpeed);
		this.rb.position = new Vector3(Mathf.Clamp(this.rb.position.x, this.boundary.xMin, this.boundary.xMax), 0, Mathf.Clamp(this.rb.position.z, this.boundary.zMin, this.boundary.zMax));
		this.rb.rotation = Quaternion.Euler(0, 0, this.rb.velocity.x * -this.tilt);
	}
}