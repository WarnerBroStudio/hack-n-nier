using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
  public GameObject[] bars;
  public bool change;
  public int currentItem;
  public Scene Level;
  // Use this for initialization
  void Start () {
    currentItem = 0;
    updateSelectedItem ();
  }

  // Update is called once per frame
  void Update () {
    if (Input.GetKeyDown ("z") || Input.GetKeyDown ("up")) {
      if (currentItem > 0) {

        currentItem -= 1;
        updateSelectedItem ();
      }
    }
    if (Input.GetKeyDown ("s") || Input.GetKeyDown ("down")) {
      if (currentItem < bars.Length - 1) {
        currentItem += 1;
        updateSelectedItem ();
      }
    }
    if (Input.GetKeyDown ("space") || Input.GetKeyDown (KeyCode.KeypadEnter) || Input.GetKeyDown (KeyCode.Return)) {
      String selected = bars[currentItem].GetComponent<Item> ().itemName;
      switch (selected) {
        case "play":
          SceneManager.LoadScene ("DebugZone");
          break;
        case "quit":
          print ("quit");
          break;
        default:
          break;
      }

      // if (barA == true) {
      //   print ("play");
      //   
      // }
      // if (barB == true) {
      //   print ("quit");
      // }
    }
  }

  void updateSelectedItem () {
    for (int i = 0; i < bars.Length; i++) {
      GameObject item = bars[i];
      if (i != currentItem) {
        item.gameObject.SetActive (false);
      } else {
        bars[currentItem].gameObject.SetActive (true);
      }
    }
  }
}