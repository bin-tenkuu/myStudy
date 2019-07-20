using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {
	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;
	public float delay;

	private AudioSource audioSource;

	private void Start() {
		this.audioSource = this.GetComponent<AudioSource>();
		this.InvokeRepeating("Fire", this.delay, this.fireRate);
	}

	private void Fire() {
		Instantiate(this.shot, this.shotSpawn.position, this.shotSpawn.rotation);
		this.audioSource.Play();
	}
	
}