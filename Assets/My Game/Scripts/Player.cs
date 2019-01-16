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

    

    SceneManagement sceneManagement;
    GameLogic gameLogic;

	// Use this for initialization
	void Start () {
        sceneManagement = GameObject.FindGameObjectWithTag("Manager").GetComponent<SceneManagement>();
        gameLogic = GameObject.FindGameObjectWithTag("Manager").GetComponent<GameLogic>();
        lives = maxLives;
        livesText.text = lives.ToString();
	}
	
	// Update is called once per frame
	void Update () {

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
            gameLogic.StopTimer();
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



    


}
