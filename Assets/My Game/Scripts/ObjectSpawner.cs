using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    //reference for deathcube and apple
    public GameObject apple;
    public GameObject deathCube;
    public GameObject megaDeathCube;
    //Serializeable spawn positions for the objects
    private GameObject[] DeathCubeSpawnPositions;
    private GameObject[] AppleSpawnPositions;
    //timer variables
    private float timerTimeDeathCubes;
    private float timerTimeApple;
    private float timerTimeMegaDeathCubes;
    public bool megaMode = false;
    public float DeathCubesSpawnTime = 2;
    public float ApplesSpawnTime = 10;
    
    //other changables
    public int minDeathCubeAmount = 2;
    public int maxDeathCubeAmount = 5;


    // Use this for initialization
    void Start () {
        DeathCubeSpawnPositions = GameObject.FindGameObjectsWithTag("DeathCubeSpawn");
        AppleSpawnPositions = GameObject.FindGameObjectsWithTag("PowerUpSpawn");
	}
	
	// Update is called once per frame
	void Update () {

        //deathcube timer
        if (timerTimeDeathCubes > 0)
        {
            timerTimeDeathCubes -= Time.deltaTime;
        }
        else if (timerTimeDeathCubes <= 0)
        {
            SpawnDeathCubes();
            timerTimeDeathCubes = DeathCubesSpawnTime;
        }

        //apple timer
        if (timerTimeApple > 0)
        {
            timerTimeApple -= Time.deltaTime;
        }
        else if (timerTimeApple <= 0)
        {
            SpawnApples();
            timerTimeApple = ApplesSpawnTime;
        }

        //megadeathcube timer
        if (timerTimeMegaDeathCubes > 0 && megaMode)
        {
            timerTimeMegaDeathCubes -= Time.deltaTime;
        }
        else if (timerTimeMegaDeathCubes <= 0 && megaMode)
        {
            SpawnMegaDeathCube();
            timerTimeMegaDeathCubes = DeathCubesSpawnTime;
        }
    }


    //function for spawning apples
    public void SpawnApples()
    {
        float randomX = Random.Range(AppleSpawnPositions[0].transform.position.x, AppleSpawnPositions[1].transform.position.x);
        Instantiate(apple, new Vector2(randomX, AppleSpawnPositions[0].transform.position.y), Quaternion.identity);
    }
    //function for spawning deathcubes
    public void SpawnDeathCubes()
    {
        for (int i = 0; i < Random.Range(minDeathCubeAmount, maxDeathCubeAmount); i++)
        {
            float randomX = Random.Range(DeathCubeSpawnPositions[0].transform.position.x, DeathCubeSpawnPositions[1].transform.position.x);
            Instantiate(deathCube, new Vector2(randomX, DeathCubeSpawnPositions[0].transform.position.y), Quaternion.identity);
        }
    }

    public void SpawnMegaDeathCube()
    {
        float randomX = Random.Range(DeathCubeSpawnPositions[0].transform.position.x, DeathCubeSpawnPositions[1].transform.position.x);
        Instantiate(megaDeathCube, new Vector2(randomX, DeathCubeSpawnPositions[0].transform.position.y), Quaternion.identity);
    }


}
