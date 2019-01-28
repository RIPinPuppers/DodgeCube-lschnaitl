using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameLogic : MonoBehaviour {

    private float timer;
    private bool setTimer = true;
    private bool l1 = true;
    private bool l2 = true;
    private bool l3 = true;
   
    public TextMeshProUGUI timerText;
    public float[] TimeLevels;

    ObjectSpawner objectSpawner;

    // Use this for initialization
    void Start ()
    {
        objectSpawner = GameObject.FindGameObjectWithTag("ObjectSpawner").GetComponent<ObjectSpawner>();
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (setTimer)
        {
            timer += Time.deltaTime;
            timerText.text = timer.ToString("F1") + " sec";
        }


        if (timer > TimeLevels[0] && l1)
        {
            l1 = false;
            objectSpawner.minDeathCubeAmount++;
            objectSpawner.maxDeathCubeAmount++;
            objectSpawner.applesSpawnTime += 5;
        }
        else if (timer > TimeLevels[1] && l2)
        {
            l2 = false;
            objectSpawner.minDeathCubeAmount++;
            objectSpawner.maxDeathCubeAmount++;
            objectSpawner.applesSpawnTime += 5;
        }
        else if (timer > TimeLevels[2] && l3)
        {
            l3 = false;
            objectSpawner.megaMode = true;
            objectSpawner.minDeathCubeAmount--;
            objectSpawner.maxDeathCubeAmount--;
            objectSpawner.applesSpawnTime += 5;
            objectSpawner.SpawnApples();

        }
    }

    public void StopTimer()
    {
        setTimer = false;
        PlayerPrefs.SetFloat("Time", timer);
    }

    public void ResetTimer()
    {
        timer = 0;
        timerText.text = "0.0 sec";
    }
}
