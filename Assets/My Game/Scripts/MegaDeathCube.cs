using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MegaDeathCube : MonoBehaviour {

    Player player;

    // Use this for initialization
    void Start()
    {
        player = GameObject.FindGameObjectWithTag(GlobalVariables.PLAYERTAG).GetComponent<Player>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag(GlobalVariables.PLAYERTAG))
        {
            player.ChangeLives(2, false);
            Destroy(this.gameObject);
        }
        else if (collision.collider.CompareTag("Floor") || collision.collider.CompareTag("Apple"))
        {
            Destroy(this.gameObject);
        }
    }
}
