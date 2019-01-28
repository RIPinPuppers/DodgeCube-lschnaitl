using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    //reference for deathcube and apple
    public GameObject apple;
    public GameObject deathCube;
    public GameObject megaDeathCube;
    //Serializeable spawn positions for the objects
    private GameObject[] deathCubeSpawnPositions;
    private GameObject[] appleSpawnPositions;
    //timer variables
    private float timerTimeDeathCubes;
    private float timerTimeApple;
    private float timerTimeMegaDeathCubes;
    public bool megaMode = false;
    public float deathCubesSpawnTime = 2;
    public float applesSpawnTime = 10;
    
    //other changables
    public int minDeathCubeAmount = 2;
    public int maxDeathCubeAmount = 5;


    // Use this for initialization
    void Start ()
    {
        deathCubeSpawnPositions = GameObject.FindGameObjectsWithTag("DeathCubeSpawn");
        appleSpawnPositions = GameObject.FindGameObjectsWithTag("PowerUpSpawn");
	}
	
	// Update is called once per frame
	void Update ()
    {

        //deathcube timer
        if (timerTimeDeathCubes > 0)
        {
            timerTimeDeathCubes -= Time.deltaTime;
        }
        else if (timerTimeDeathCubes <= 0)
        {
            SpawnDeathCubes();
            timerTimeDeathCubes = deathCubesSpawnTime;
        }

        //apple timer
        if (timerTimeApple > 0)
        {
            timerTimeApple -= Time.deltaTime;
        }
        else if (timerTimeApple <= 0)
        {
            SpawnApples();
            timerTimeApple = applesSpawnTime;
        }

        //megadeathcube timer
        if (timerTimeMegaDeathCubes > 0 && megaMode)
        {
            timerTimeMegaDeathCubes -= Time.deltaTime;
        }
        else if (timerTimeMegaDeathCubes <= 0 && megaMode)
        {
            SpawnMegaDeathCube();
            timerTimeMegaDeathCubes = deathCubesSpawnTime;
        }
    }


    //function for spawning apples
    public void SpawnApples()
    {
        float randomX = Random.Range(appleSpawnPositions[0].transform.position.x, appleSpawnPositions[1].transform.position.x);
        Instantiate(apple, new Vector2(randomX, appleSpawnPositions[0].transform.position.y), Quaternion.identity);
    }
    //function for spawning deathcubes
    public void SpawnDeathCubes()
    {
        for (int i = 0; i < Random.Range(minDeathCubeAmount, maxDeathCubeAmount); i++)
        {
            float randomX = Random.Range(deathCubeSpawnPositions[0].transform.position.x, deathCubeSpawnPositions[1].transform.position.x);
            Instantiate(deathCube, new Vector2(randomX, deathCubeSpawnPositions[0].transform.position.y), Quaternion.identity);
        }
    }

    public void SpawnMegaDeathCube()
    {
        float randomX = Random.Range(deathCubeSpawnPositions[0].transform.position.x, deathCubeSpawnPositions[1].transform.position.x);
        Instantiate(megaDeathCube, new Vector2(randomX, deathCubeSpawnPositions[0].transform.position.y), Quaternion.identity);
    }


}
