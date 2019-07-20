using System;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	public GameObject explosion;
	public GameObject PlayerExplosion;
	public int scoreValue;

	private GameController gc;

	private void Start() {
		GameObject go = GameObject.FindWithTag("GameController") ??
			throw new NullReferenceException("Cannot found 'GameController' script!");
		this.gc = go.GetComponent<GameController>();
	}

	private void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Boundary") || other.CompareTag("Enemy")) {
			return;
		}
		if (this.explosion != null) {
			Instantiate(this.explosion, this.transform.position, this.transform.rotation);
		}
		if (other.CompareTag("Player")) {
			Instantiate(this.PlayerExplosion, other.transform.position, other.transform.rotation);
			this.gc.GameOver();
		}
		this.gc.AddScore(this.scoreValue);
		Destroy(other.gameObject);
		Destroy(this.gameObject);
	}
}
