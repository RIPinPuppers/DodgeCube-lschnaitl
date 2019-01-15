using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameOverScreen : MonoBehaviour {

    public TextMeshProUGUI time;

	// Use this for initialization
	void Start () {

        time.text = PlayerPrefs.GetFloat("Time", 0).ToString("F1") + " sec";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    

}
