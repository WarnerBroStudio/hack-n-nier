using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
  public GameObject player;
  public GameObject shoot;
  public GameObject enemy1;
  void Start () {
    Cursor.visible = false;
    // StartCoroutine(enemy1.GetComponent<Enemy1> ().StartSpawner());
    enemy1.GetComponent<Enemy1> ().Spawn();

  }

  void Update () {
    if (Input.GetButton ("up")) {
      transform.position += transform.up * 2.0f * Time.deltaTime;
    }

    if (Input.GetButton ("down")) {
      transform.position += transform.up * -2.0f * Time.deltaTime;
    }

    if (Input.GetButton ("right")) {
      transform.Rotate (0, 0, 2.0f);
    }

    if (Input.GetButton ("left")) {
      transform.Rotate (0, 0, 2.0f);
    }

    if (Input.GetKeyDown ("space")) {
      GameObject newShoot = Instantiate (shoot, new Vector2 (0, 0), player.transform.rotation);
      newShoot.transform.position = new Vector2 (player.transform.position.x, player.transform.position.y);
      newShoot.transform.Translate (new Vector2 (0, 0.7f));
    }
  }
}