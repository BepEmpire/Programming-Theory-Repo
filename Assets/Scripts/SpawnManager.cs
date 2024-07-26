using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject cupcake;
    [SerializeField] private GameObject donut;
    [SerializeField] private GameObject mushroom;

    [SerializeField] private float xSpawnLeft = -8.0f;
    [SerializeField] private float xSpawnRight = 12.0f;
    [SerializeField] private float ySpawn = 10.0f;
    [SerializeField] private float zSpawn = 0.0f;

    [SerializeField] private float cupcakeSpawnTime = 3.0f;
    [SerializeField] private float donutSpawnTime = 5.0f;
    [SerializeField] private float mushroomSpawnTime = 8.0f;
    [SerializeField] private float startDelay = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCupcake", startDelay, cupcakeSpawnTime);
        InvokeRepeating("SpawnDonut", startDelay, donutSpawnTime);
        InvokeRepeating("SpawnMushroom", startDelay, mushroomSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCupcake()
    {
        float randomX = Random.Range(xSpawnLeft, xSpawnRight);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zSpawn);

        Instantiate(cupcake, spawnPos, cupcake.gameObject.transform.rotation);
    }

    void SpawnDonut()
    {
        float randomX = Random.Range(xSpawnLeft, xSpawnRight);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zSpawn);

        Instantiate(donut, spawnPos, donut.gameObject.transform.rotation);
    }

    void SpawnMushroom()
    {
        float randomX = Random.Range(xSpawnLeft, xSpawnRight);

        Vector3 spawnPos = new Vector3(randomX, ySpawn, zSpawn);

        Instantiate(mushroom, spawnPos, mushroom.gameObject.transform.rotation);
    }

}
