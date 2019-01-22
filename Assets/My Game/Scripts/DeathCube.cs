using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathCube : MonoBehaviour {

    Player player;

	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Player>();
	}

    //create collision detection
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            player.ChangeLives(1, false);
            Destroy(this.gameObject);
        }
        else if (collision.collider.CompareTag("Floor") || collision.collider.CompareTag("Apple"))
        {
            Destroy(this.gameObject);
        }
    }
}
