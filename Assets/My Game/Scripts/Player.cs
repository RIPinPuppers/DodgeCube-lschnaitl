using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour {

    [SerializeField] private float speed;
    [SerializeField] private float rotSpeed = 1f;

    [HideInInspector] public int lives;
    public int maxLives = 3;
    public Color deathHitColor;
    public TextMeshProUGUI livesText;

    [SerializeField] Transform rightBorder;
    [SerializeField] Transform leftBorder;

    SceneManagement sceneManagement;
    GameLogic gameLogic;

	// Use this for initialization
	void Start ()
    {
        sceneManagement = GameObject.FindGameObjectWithTag(GlobalVariables.MANAGERTAG).GetComponent<SceneManagement>();
        gameLogic = GameObject.FindGameObjectWithTag(GlobalVariables.MANAGERTAG).GetComponent<GameLogic>();
        lives = maxLives;
        livesText.text = lives.ToString();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (transform.position.x <= rightBorder.position.x)
        {
            //move the player right
            if (Input.GetKey(KeyCode.D)) // enum 
            {
                transform.position += new Vector3(1 * speed, 0, 0);
                transform.Rotate(new Vector3(0,0,-1 * rotSpeed));
            }
        }

        if (transform.position.x >= leftBorder.position.x)
        {
            //move the player left 
            if (Input.GetKey(KeyCode.A))
            {
                transform.position += new Vector3(1 * -speed, 0, 0);
                transform.Rotate(new Vector3(0, 0, 1 * rotSpeed));
            }
        }

        if (lives <= 0)
        {
            gameLogic.StopTimer();
            sceneManagement.ChangeToScene("GameOver");
        }
    }

    public void ChangeLives(int amount, bool mode)
    {
        if (mode)
            lives += amount;
        else
            lives -= amount;

        livesText.text = lives.ToString();
    }
}
