using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	public GameObject cube;
	public float speed;
	Vector3 targetPosition;
	public static Player instance;
	public bool gameOver = false;

	void Awake(){
		instance = this;
	}
	void Update(){
		CreateCube ();
	}

	void FixedUpdate (){
		Controller ();
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Enemy") {
			gameOver = true;
			Time.timeScale = 0;
		}
	}

	void Controller(){
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		transform.Translate (movement * speed * Time.deltaTime);
	}
	void CreateCube(){
		if (Input.GetButtonDown("Fire1")) {
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit;
			if (Physics.Raycast(ray, out hit)){
				targetPosition = hit.point;
				GameObject obj = Instantiate(cube,targetPosition , transform.rotation) as GameObject;
				Destroy(obj, 1);

			}
		}
	}
}
