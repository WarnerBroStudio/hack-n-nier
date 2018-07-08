using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {
	public float force;

	// Use this for initialization
	void Start () {
		Cursor.visible = false;
	}

	// Update is called once per frame
	void Update () {
		// if (Input.GetButton ("Rotation X+")) {
		// 	transform.Rotate (0, 0, -force);
		// }
		// if (Input.GetButton ("Rotation X-")) {
		// 	transform.Rotate (0, 0, force);
		// }
	}
}