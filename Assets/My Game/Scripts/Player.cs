using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotSpeed = 1f;

    public int lives;
    public int maxLives;
    public Color deathHitColor;
    public TextMeshProUGUI livesText;

    public TextMeshProUGUI timerText;
    private float timer;
    private bool setTimer = true;

    SceneManagement sceneManagement;

	// Use this for initialization
	void Start () {
        sceneManagement = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneManagement>();
        lives = maxLives;
        livesText.text = lives.ToString();
	}
	
	// Update is called once per frame
	void Update () {


        if (setTimer)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString("F1") + " sec";
        }


        //move the player right
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(1 * speed, 0, 0);
            transform.Rotate(new Vector3(0,0,-1 * rotSpeed));
        }

        //move the player left 
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(1 * -speed, 0, 0);
            transform.Rotate(new Vector3(0, 0, 1 * rotSpeed));
        }

        if(lives <= 0)
        {
            setTimer = false;
            PlayerPrefs.SetFloat("Time", timer);
            sceneManagement.ChangeToScene("GameOver");

        }

        //restrict movement to the floor borders
        
    }

    public void ChangeLives(int amount, bool mode)
    {
        if (mode)
        {
            lives += amount;
        }
        else
        {
            lives -= amount;
        }
        livesText.text = lives.ToString();
    }



    public void ResetTimer()
    {
        timer = 0;
        timerText.text = "0.0 sec";
    }


}
