using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public GameObject[] hazards;
	public Vector3 spawnValue;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	public Text scoreText;
	//public Text restartText;
	public Text gameOverText;
	public GameObject restartButton;

	private int score;
	private Quaternion spawnRotate;
	//private bool restart;
	private bool gameOver;

	private void Start() {
		this.spawnRotate = Quaternion.identity;
		this.StartCoroutine(this.SpawnWaves());
		this.score = 0;
		this.UpdateScore();
		//this.restartText.text = "";
		//this.restart = false;
		this.restartButton.SetActive(false);
		this.gameOverText.text = "";
		this.gameOver = false;
	}

	//private void Update() {
	//	if (this.restart) {
	//		if (Input.GetKeyDown(KeyCode.R)) {
	//			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	//		}
	//	}
	//}
	public void RestartGame() {
		SceneManager.LoadScene(SceneManager.GetActiveScene().name);
	}

	public void GameOver() {
		this.gameOverText.text = "Game Over";
		this.gameOver = true;
	}

	public void AddScore(int changeValue) {
		this.score += changeValue;
		this.UpdateScore();
	}

	private void UpdateScore() {
		this.scoreText.text = $"Score: {this.score}";
	}

	private IEnumerator SpawnWaves() {
		yield return new WaitForSeconds(this.startWait);
		while (true) {
			for (int i = 0; i < this.hazardCount; i++) {
				GameObject hazard = this.hazards[Random.Range(0, this.hazards.Length)];
				Vector3 spawnPosition = new Vector3(Random.Range(-this.spawnValue.x, this.spawnValue.x), this.spawnValue.y, this.spawnValue.z);
				Instantiate(hazard, spawnPosition, this.spawnRotate);
				yield return new WaitForSeconds(this.spawnWait);
			}
			yield return new WaitForSeconds(this.waveWait);
			if (this.gameOver) {
				//this.restartText.text = "Press 'R' to restart!";
				this.restartButton.SetActive(true);
				//this.restart = true;
				break;
			}
		}
	}
}
