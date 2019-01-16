using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RNG : MonoBehaviour {

	// Use this for initialization
	void Start () {

        
        System.Random rnd = new System.Random(123);
        Debug.Log("System: " + rnd.Next(1,5));
        Debug.Log("System: " + rnd.Next(1, 5));
        Debug.Log("System: " + rnd.Next(1, 5));

        Debug.Log("Unity: " + UnityEngine.Random.Range(1,5));

        RNGnice();
        Debug.Log("flaot method: " + RNGFloat());

        Debug.Log("int method: " + RandomValue());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void RNGnice()
    {
        Debug.Log("Method: " + UnityEngine.Random.Range(1, 5));
    }

    float RNGFloat()
    {
        float rnd = UnityEngine.Random.Range(1,5);
        return rnd;
    }

    public int RandomValue()
    {
        System.Random rnd = new System.Random(123);
        return rnd.Next(1, 5);
    }
}
