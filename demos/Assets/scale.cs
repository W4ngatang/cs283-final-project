using UnityEngine;
using System.Collections;

public class scale : MonoBehaviour {
	
	public float speed = 1.0f;
		
	// Update is called once per frame
	void Update () {
		
		var scale = new Vector3 (Input.GetAxis ("Move2"), 0, Input.GetAxis ("Move2"));
		transform.localScale += scale * speed * Time.deltaTime;
	}
}
