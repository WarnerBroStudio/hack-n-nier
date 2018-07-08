using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour {
  public AudioClip Death_Crash;
  public bool play;

  // Use this for initialization
  void Start () { }

  // Update is called once per frame
  void Update () {
    if (play == false) {
      if (GameObject.Find ("Player") != null) { } else {
        AudioSource audio = GetComponent<AudioSource> ();
        audio.PlayOneShot (Death_Crash);
      }
    }
  }
}