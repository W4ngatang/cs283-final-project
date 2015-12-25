using UnityEngine;
using System.Collections;

public class move_cross : MonoBehaviour {

	public float speed = 1.0f;
	
	// Update is called once per frame
	void Update() {
		var move = new Vector3(0, 0, Input.GetAxis("Move4"));
		transform.position += move * speed * Time.deltaTime;
		
	} 
}
