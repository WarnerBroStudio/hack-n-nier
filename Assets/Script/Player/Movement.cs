using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
  public float x;
  public float y;
  public float force;
  public GameObject player;
  public GameObject shoot;
  public Transform playerTransform;

  void Start () {
    Cursor.visible = false;
  }

  void Update () {
    if (Input.GetButton ("up")) {
      transform.Translate (new Vector2 (0, y));
    }

    if (Input.GetButton ("down")) {
      transform.Translate (new Vector2 (0, -y));
    }

    if (Input.GetButton ("right")) {
      transform.Rotate (0, 0, -force);
    }

    if (Input.GetButton ("left")) {
      transform.Rotate (0, 0, force);
    }

    if (Input.GetButton ("fire")) {
      Instantiate (shoot, player.transform.position, player.transform.rotation );
    }
  }
}