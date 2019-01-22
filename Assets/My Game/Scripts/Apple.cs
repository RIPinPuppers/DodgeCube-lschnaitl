using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : MonoBehaviour {

    Player player;
    [SerializeField] private readonly float timeActive = 5;
    
	// Use this for initialization
	void Start ()
    {
        player = GameObject.FindGameObjectWithTag(GlobalVariables.PLAYERTAG).GetComponent<Player>();
        Destroy(this.gameObject, timeActive);
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(GlobalVariables.PLAYERTAG))
        {
            if (player.lives < player.maxLives)
            {
                player.ChangeLives(1, true);
                Destroy(this.gameObject);
            }
        }
    }
}
