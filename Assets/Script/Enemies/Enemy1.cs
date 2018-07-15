using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour {
	public float health = 3.0f;

	public GameObject Spawn (Vector2 position, Quaternion rotation) {
		return Instantiate (gameObject, position, rotation);
	}
	public GameObject Spawn (Vector2 position) {
		return Instantiate (gameObject, position, new Quaternion (0, 0, 0, 0));
	}
	public GameObject Spawn () {
		return Instantiate (gameObject, new Vector2 (2.0f, -1f), new Quaternion (0, 0, 0, 0));
	}

	public float Inflict (float damage) {
		this.health -= damage;
		if (this.health <= 0) {
			Destroy (this.gameObject);
		}
		return this.health;
	}
}