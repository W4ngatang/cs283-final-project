using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	
	public float speed = 1.0f;

	// Update is called once per frame
	void Update() {
		var move = new Vector3(Input.GetAxis("Move1"), 0, 0);
		transform.position += move * speed * Time.deltaTime;

	}
}
