using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverScreen : MonoBehaviour {

    public Text time;

	// Use this for initialization
	void Start () {
        time.text = PlayerPrefs.GetFloat("Time", 0).ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    

}
