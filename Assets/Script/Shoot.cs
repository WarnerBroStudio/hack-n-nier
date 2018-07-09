using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
  public GameObject player;
  public float speed;
  public bool bouge = false;

  void Start () {
    if (gameObject.name.Contains ("(Clone)")) {
      Destroy (gameObject, 1);
    }
  }

  void Update () {
    transform.Translate (new Vector2 (0, speed));
  }
}