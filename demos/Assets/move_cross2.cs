using UnityEngine;
using System.Collections;

public class move_cross2 : MonoBehaviour {

	public float speed = 1.0f;
	
	// Update is called once per frame
	void Update() {
		var move = new Vector3(Input.GetAxis("Move4"), 0, 0);
		transform.position += move * speed * Time.deltaTime;
		
	} 
}
