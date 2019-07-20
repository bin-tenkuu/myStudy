using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 子弹移动类
/// </summary>
public class Mover : MonoBehaviour {
	private Rigidbody rb;
	/// <summary>
	/// 移动速度
	/// </summary>
	public float speed = 1;
	/// <summary>
	/// 初始化
	/// </summary>
	private void Start() {
		this.rb = this.GetComponent<Rigidbody>();
		this.rb.velocity = this.transform.forward * this.speed;
	}
	
	private void Update() {

	}
}
