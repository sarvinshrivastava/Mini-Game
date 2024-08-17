using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningAnimalScript : MonoBehaviour
{
    // SerializeField variables
    [SerializeField] private GameObject[] animalPrefabs;
    [SerializeField] private GameObject sandwitch;

    // Private variables
    private float spawnRangeX = 20.0f;
    private float spawnRangeZup = 30.0f;
    private float spawnRangeZdown = 4.5f;
    private float delay = 2.0f;
    private int spawnCount = 0;
    private bool canIncreaseSpeed = false;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 0.1f, delay);
    }

    void SpawnRandomAnimal()
    {
        Debug.Log("Spawning animal");
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(spawnRangeZdown, spawnRangeZup));

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
        spawnCount++;
        if (spawnCount % 7 == 0 && delay > 0.0f)
        {
            delay -= 0.1f;
            canIncreaseSpeed = true;
        }
    }

    public bool GetCanIncreaseSpeed()
    {
        return canIncreaseSpeed;
    }

    public void SetCanIncreaseSpeed()
    {
        canIncreaseSpeed = false;
    }
}
