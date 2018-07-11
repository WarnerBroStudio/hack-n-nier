using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	private float time;
	public GameObject[] enemmies;
	void Start () {
		this.time = 1f;
		StartCoroutine (this.StartSpawner ());
	}

	public IEnumerator StartSpawner () {
		while (true) {
			System.Random aleatoire = new System.Random ();
			int enemyIndex = aleatoire.Next (this.enemmies.Length);
			GameObject enemy = this.enemmies[enemyIndex];
			enemy.GetComponent<Enemy1> ().Spawn ();
			yield return new WaitForSeconds (this.time);
		}
	}

}