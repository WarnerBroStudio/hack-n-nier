using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
  public GameObject player;
  public float speed;
  public bool bouge = false;

  void Start () {
    speed = 10.0f;
    if (gameObject.name.Contains ("(Clone)")) {
      Destroy (gameObject, 1);
    }
  }

  void Update () {
    if (gameObject.name.Contains ("(Clone)")) {
      transform.Translate (Vector3.up * Time.deltaTime * speed);
    }
  }
  void OnCollisionEnter2D (Collision2D col) {
    if (gameObject.name.Contains ("(Clone)")) {
      Destroy (gameObject);
    }
  }
}