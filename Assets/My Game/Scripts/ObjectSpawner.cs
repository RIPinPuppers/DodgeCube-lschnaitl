using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour {

    //reference for deathcube and apple
    public GameObject apple;
    public GameObject deathCube;
    //Serializeable spawn positions for the objects
    private GameObject[] DeathCubeSpawnPositions;
    private GameObject[] AppleSpawnPositions;
    //timer variables
    private float timerTimeDeathCubes;
    private float timerTimeApple;
    [SerializeField]
    private float DeathCubesSpawnTime = 2;
    [SerializeField]
    private float ApplesSpawnTime = 10;


    //other changables
    public int minDeathCubeAmount = 2;
	// Use this for initialization
	void Start () {
        DeathCubeSpawnPositions = GameObject.FindGameObjectsWithTag("DeathCubeSpawn");
        AppleSpawnPositions = GameObject.FindGameObjectsWithTag("AppleSpawn");
        SpawnDeathCubes();
	}
	
	// Update is called once per frame
	void Update () {

        //create timer
        if (timerTimeDeathCubes > 0)
        {
            timerTimeDeathCubes -= Time.deltaTime;
        }
        else if (timerTimeDeathCubes <= 0)
        {
            SpawnDeathCubes();
            timerTimeDeathCubes = DeathCubesSpawnTime;
        }

        if (timerTimeApple > 0)
        {
            timerTimeApple -= Time.deltaTime;
        }
        else if (timerTimeApple <= 0)
        {
            SpawnApples();
            timerTimeApple = ApplesSpawnTime;
        }


        //spawn deathcubes - random spawnposition

        //spawn apples - random spawnposition


    }


    //function for spawning apples
    void SpawnApples()
    {
        print("Spawning Apples");
        Instantiate(apple, AppleSpawnPositions[Random.Range(0, AppleSpawnPositions.Length)].transform.position, Quaternion.identity);
    }
    //function for spawning deathcubes
    void SpawnDeathCubes()
    {
        print("Spawning DeathCubes");
        for (int i = 0; i < Random.Range(minDeathCubeAmount, DeathCubeSpawnPositions.Length); i++)
        {
            
            Instantiate(deathCube, DeathCubeSpawnPositions[Random.Range(0, DeathCubeSpawnPositions.Length)].transform.position, Quaternion.identity);
            
        }
    }
}
