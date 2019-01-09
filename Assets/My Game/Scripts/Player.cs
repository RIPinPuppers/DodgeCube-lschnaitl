using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField]
    private float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {


        //move the player right
        if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Pressed D");
            transform.position += new Vector3(1 * speed, 0, 0);

        }

        //move the player left 
        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Pressed A");
            transform.position += new Vector3(1 * -speed, 0, 0);
        }

        //restrict movement to the floor borders

    }
}
