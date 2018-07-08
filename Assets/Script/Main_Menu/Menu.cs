using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {
public GameObject bar1;
public GameObject bar2; 
public bool barA;
public bool barB;
public Scene Level; 
	// Use this for initialization
	void Start () {
		bar2.gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("s"))
			{
				bar1.gameObject.SetActive(false);
				barA = (false);
				bar2.gameObject.SetActive(true);
				barB = (true);
			}

		if(Input.GetKeyDown("z"))
			{
				bar2.gameObject.SetActive(false);
				barB = (false);
				bar1.gameObject.SetActive(true);
				barA = (true);
			}

		if(Input.GetKeyDown("space"))
			{
				if(barA==true)
					{
						print("play");
						SceneManager.LoadScene("DebugZone");
					}
				if(barB==true)
					{
						print("quit");
					}
			}

			


	}
}
