using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
  public float x;
  public float y;

  void Start () {

  }

  void Update () {
    if (Input.GetButton ("Avancer")) {
      transform.Translate (new Vector2 (0, y));
    }

    if (Input.GetButton ("Reculer")) {
      transform.Translate (new Vector2 (0, -y));
    }

    if (Input.GetButton ("Droite")) {
      transform.Translate (new Vector2 (x, 0));
    }

    if (Input.GetButton ("Gauche")) {
      transform.Translate (new Vector2 (-x, 0));
    }

    if (Input.GetButton ("Fire")) {}
  }
}