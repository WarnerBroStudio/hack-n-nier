using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Over : MonoBehaviour {
  public GameObject Bar1;
  public GameObject Bar2;
  public string Reload;

  void Start () {
    Bar1.SetActive (true);
    Bar2.SetActive (false);
  }

  void Update () {
    if (Input.GetButtonDown ("up")) {
      Bar1.SetActive (true);
      Bar2.SetActive (false);
    }
    if (Input.GetButtonDown ("down")) {
      Bar1.SetActive (false);
      Bar2.SetActive (true);
    }
    if (Bar1 == true) {
      if (Input.GetKeyDown ("space")) {
        Scene scene = SceneManager.GetActiveScene ();
        SceneManager.LoadScene (scene.name);
      }
    }
    if (Bar2 == true) {
      if (Input.GetKeyDown ("space")) {
        Application.Quit ();
      }
    }
  }
}