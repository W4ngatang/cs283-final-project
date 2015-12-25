using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	public float speed = 1.0f;

	// Update is called once per frame
	void Update () {

		var rot = new Vector3 (0, Input.GetAxis ("Move3"), 0);
		transform.Rotate(rot * speed * Time.deltaTime, Space.World);
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);

	}
}
