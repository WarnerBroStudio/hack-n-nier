using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
public byte Time_for_level;
public GameObject Player;
public Text Text_Time;
	// Use this for initialization
	void Start () {
		InvokeRepeating("Decrease",1f, 1f);
		Text_Time = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time_for_level == 0){
			Destroy (Player);
		}
		 if(GameObject.Find("Player")){
    	 Text_Time.text = "Time : " + Time_for_level;
		}
	}

	void Decrease () {
		Time_for_level--; 
	}
}
