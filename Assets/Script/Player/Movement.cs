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
  private Rigidbody2D rb;

  void Start () {
    Cursor.visible = false;
  }

  void Update () {
    if (Input.GetButton ("up")) {
       transform.position += transform.up * 2.0f * Time.deltaTime;
    }

    if (Input.GetButton ("down")) {
       transform.position += transform.up * -2.0f * Time.deltaTime;
    }

    if (Input.GetButton ("right")) {
      transform.Rotate (0, 0, -force);
    }

    if (Input.GetButton ("left")) {
      transform.Rotate (0, 0, force);
    }

    if (Input.GetKeyDown ("space")) {
      GameObject newShoot = Instantiate (shoot, new Vector2(0,0), player.transform.rotation);
      newShoot.transform.position = new Vector2(player.transform.position.x, player.transform.position.y);
      newShoot.transform.Translate(new Vector2(0, 0.7f));
    }
  }
}