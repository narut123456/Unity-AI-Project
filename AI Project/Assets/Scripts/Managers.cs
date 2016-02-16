using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Managers : MonoBehaviour {
	public GameObject enemy;
	public GameObject current;
	public Text timeText;
	public Text timeCurrent;
	private float time = 0;
	public Vector3[] spawnPoint;
	int x = 0;
	
	void Start () {
		Time.timeScale = 1;
		current.SetActive (false);
	}

	void Update () {
		Counter ();
		CloneEnemy ();
		if (Player.instance.gameOver) {
			current.SetActive(true);
			timeCurrent.text = "Time : " + time.ToString ("####.00");
		}
	}
	void Counter(){
		if (Player.instance.gameOver == false) {
			time += Time.deltaTime;
			timeText.text = "Time: " + time.ToString ("####.00");
		}
	}
	public void Button(){
		Application.LoadLevel ("Test");
	}
	void CloneEnemy(){
		if (time < 5 && x == 0) {
			x = 1;
			Instantiate(enemy, spawnPoint[Random.Range(0,spawnPoint.Length-1)], Quaternion.identity);
		}
		if (time > 5 && x == 1) {
			x = 2;
			Instantiate(enemy, spawnPoint[Random.Range(0,spawnPoint.Length-1)], Quaternion.identity);
		}
		if (time > 10 && x == 2) {
			x = 3;
			Instantiate(enemy, spawnPoint[Random.Range(0,spawnPoint.Length-1)], Quaternion.identity);
		}
		if (time > 20 && x == 3) {
			x = 4;
			Instantiate(enemy, spawnPoint[Random.Range(0,spawnPoint.Length-1)], Quaternion.identity);
		}
		if (time > 40 && x == 4) {
			x = 5;
			Instantiate(enemy, spawnPoint[Random.Range(0,spawnPoint.Length-1)], Quaternion.identity);
		}
/*		if (time > 20 && x == 5) {
			x = 6;
			Instantiate(enemy, spawnPoint[Random.Range(0,spawnPoint.Length-1)], Quaternion.identity);
		}
		if (time > 25 && x == 6) {
			x = 7;
			Instantiate(enemy, spawnPoint[Random.Range(0,spawnPoint.Length-1)], Quaternion.identity);
		}
*/	}
}
