using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
  public int timeForLevel;
  public Life player;
  public Text textTime;
  public Coroutine coroutine;

  void Start () {
    this.timeForLevel = 10;
    this.textTime = GetComponent<Text> ();
    StartCoroutine (this.StartSpawner (1));
  }

  public IEnumerator StartSpawner (int delay) {
    this.timeForLevel--;
    this.textTime.text = "Time : " + this.timeForLevel;
    if (this.timeForLevel == 0) {
      this.player.Kill ();
    } else {
      yield return new WaitForSeconds (1);
      StartCoroutine (this.StartSpawner (1));
    }
  }
}