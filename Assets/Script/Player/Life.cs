using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Life : MonoBehaviour {
  public int Vie;
  public GameObject Player;
  public bool Dead;

  void Start () {
    Dead = false;
  }

  void Update () {
    if (Vie == 0) {
      Dead = true;
      Destroy (Player);
    }

    if (Input.GetKeyDown ("space")) {
      Vie--;
    }

  }
}