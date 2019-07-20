using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 玩家控制类
/// </summary>
public class PlayerController : MonoBehaviour {
	/// <summary>
	/// 速度
	/// </summary>
	public float speed = 10;
	/// <summary>
	/// 控制转向
	/// </summary>
	public float tilt;
	public Boundary bdr;
	public float fireRate;
	public GameObject Shot;
	public SimpleTouchPad touchPad;
	public SimpleTouchAreaButton areaButton;

	public Transform[] shotSpawns;
	private Rigidbody rb;
	private float nextFire = 0;
	private AudioSource audioSource;
	private Quaternion calibrationQuaternion;

	/// <summary>
	/// 初始化
	/// </summary>
	private void Start() {
		this.CalibrateAccelerometer();
		this.rb = this.GetComponent<Rigidbody>();
		this.audioSource = this.GetComponent<AudioSource>();
	}
	private void Update() {
		if (/*Input.GetButton("Fire1") /*||*/ this.areaButton.CanFire() && Time.time > this.nextFire) {
			this.nextFire = Time.time + this.fireRate;
			foreach (Transform shotSpawn in this.shotSpawns) {
				Instantiate(this.Shot, shotSpawn.position, shotSpawn.rotation);
			}
			this.audioSource.Play();
		}
	}

	//Used to calibrate the Iput.acceleration input
	private void CalibrateAccelerometer() {
		Vector3 accelerationSnapshot = Input.acceleration;
		Quaternion rotateQuaternion = Quaternion.FromToRotation(new Vector3(0.0f, 0.0f, -1.0f), accelerationSnapshot);
		this.calibrationQuaternion = Quaternion.Inverse(rotateQuaternion);
	}

	//Get the 'calibrated' value from the Input
	private Vector3 FixAcceleration(Vector3 acceleration) {
		Vector3 fixedAcceleration = this.calibrationQuaternion * acceleration;
		return fixedAcceleration;
	}

	/// <summary>
	/// 移动
	/// </summary>
	private void FixedUpdate() {
		/*
		float moveHorizontal = Input.GetAxis("Horizontal");
		float moveVertical = Input.GetAxis("Vertical");
		Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);
		*/
		/*
		Vector3 accleration = Input.acceleration;
		Vector3 acclerationRaw = this.FixAcceleration(accleration);
		Vector3 movement = new Vector3(accleration.x, 0, accleration.y);
		*/
		//*
		Vector2 direction = this.touchPad.GetDirection();
		Vector3 movement = new Vector3(direction.x, 0, direction.y);
		//*/
		this.rb.velocity = movement * this.speed;
		this.rb.position = new Vector3(Mathf.Clamp(this.rb.position.x, this.bdr.xMin, this.bdr.xMax), 0, Mathf.Clamp(this.rb.position.z, this.bdr.zMin, this.bdr.zMax));
		this.rb.rotation = Quaternion.Euler(0, 0, -this.rb.velocity.x * this.tilt);
	}
}
