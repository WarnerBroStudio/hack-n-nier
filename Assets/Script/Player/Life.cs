using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Life : MonoBehaviour {
  public int health;
  public bool dead = false;
  public GameObject UI;
  public bool fxAlreadyLaunch = false;
  public AudioSource audio;
  public Spawner spawner;

  public void Inflict () {
    this.health--;
    if (this.health <= 0) {
      this.dead = true;
      this.Kill ();
    }
  }

  public void Kill () {
    this.fxAlreadyLaunch = true;
    this.audio.Play ();
    UI.SetActive (true);
    StopCoroutine (this.spawner.coroutine);
    Destroy (this.gameObject);
  }
}