using UnityEngine;
using System.Collections;

public class FollowCamera : MonoBehaviour {
	public GameObject target;
	private Vector3 offset;
	Vector3 targetPos;

	void Start () {
		offset = transform.position - target.transform.position;
	}

	void FixedUpdate () {
		if (target)
		{
			transform.position = target.transform.position + offset;
		}
	}
}
