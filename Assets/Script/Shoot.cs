using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
  public GameObject player;
  public float speed;
  public float damage;
  public bool bouge = false;

  void Start () {
    this.speed = 10.0f;
    this.damage = 2.0f;
    if (this.gameObject.name.Contains ("(Clone)")) {
      Destroy (this.gameObject, 1);
    }
  }

  void Update () {
    if (this.gameObject.name.Contains ("(Clone)")) {
      transform.Translate (Vector3.up * Time.deltaTime * this.speed);
    }
  }

  void OnCollisionEnter2D (Collision2D col) {
    if (this.gameObject.name.Contains ("(Clone)")) {
      if (col.gameObject.GetComponent<Enemy1> () != null) {
        col.gameObject.GetComponent<Enemy1> ().Inflict (this.damage);
      }
      Destroy (this.gameObject);
    }
  }
}