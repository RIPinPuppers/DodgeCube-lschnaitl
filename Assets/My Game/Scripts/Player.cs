using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotSpeed = 1f;

    public int lives;
    public int maxLives;
    public TextMesh livesText;

    SceneManagement sceneManagement;

	// Use this for initialization
	void Start () {
        sceneManagement = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<SceneManagement>();
        lives = maxLives;
	}
	
	// Update is called once per frame
	void Update () {

        //livesText.text = lives.ToString();

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
            sceneManagement.ChangeToScene("GameOver");
        }

        //restrict movement to the floor borders

    }

    //detect collision
    

}
