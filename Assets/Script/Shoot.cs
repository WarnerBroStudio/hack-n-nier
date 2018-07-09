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
    if (gameObject.name.Contains ("(Clone)")) {
      transform.Translate (new Vector2 (0, speed));
    }
  }
  void OnCollisionEnter (Collision col) {
    Debug.Log (col.gameObject.name);
    if (col.gameObject.name == "prop_powerCube") {
      Destroy (col.gameObject);
    }
  }
}