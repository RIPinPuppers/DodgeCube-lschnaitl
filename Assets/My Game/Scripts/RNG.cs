using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class RNG : MonoBehaviour {

    public TextMeshProUGUI numberText;

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

        Debug.Log("method with seed and minMax as paramenters: " + RandomValueSeed(345, 1,5));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RNGnice()
    {
        int num = UnityEngine.Random.Range(1, 5);
        Debug.Log("Method: " + num);
        numberText.text = num.ToString();
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

    public int RandomValueSeed(int seed, int min, int max)
    {
        System.Random rnd = new System.Random(seed);
        return rnd.Next(min, max);
    }
}
