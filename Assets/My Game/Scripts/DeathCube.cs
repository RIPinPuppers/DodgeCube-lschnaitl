using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCube : MonoBehaviour {

    Player player;

	// Use this for initialization
	void Start () {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}
	
	// Update is called once per frame
	void Update () {
		

        //tweak the movement (is rigidbody, so no actual falling code required)

	}

    //create collision detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            player.ChangeLives(1, false);
        }
        else if (collision.collider.CompareTag("Floor"))
        {
            Destroy(this.gameObject);
        }
    }
}
