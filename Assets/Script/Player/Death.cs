using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
  public AudioSource audio;
  public GameObject UI;
  public bool fxAlreadyLaunch = false;

  void Start () {
    audio = GetComponent<AudioSource> ();
  }

  void Update () {
    if (GameObject.Find ("Player") == null && !fxAlreadyLaunch) {
      fxAlreadyLaunch = true;
      audio.Play ();
      UI.SetActive(true);
    }
  }
}