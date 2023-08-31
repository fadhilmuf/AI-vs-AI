using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject rock, paper, scissors, maps;
    public int rockSpawn, paperSpawn, scissorsSpawn;
    public int max;

    void Start()
    {
        max = rockSpawn + paperSpawn + scissorsSpawn;
        
        rockSpawner();
        paperSpawner();
        scissorsSpanwner();
    }

    void Update()
    {
        
    }

    void rockSpawner()
    {
        for(int i = 0; i<rockSpawn; i++)
        {
            float randomX = Random.Range(-15f, 15f);
            float randomY = Random.Range(-8f, 8f);

            Vector3 spawnPosition = maps.transform.position + new Vector3(randomX, randomY);

            Instantiate(rock, spawnPosition, Quaternion.identity);
        }
    }
    void paperSpawner()
    {
        for(int i = 0; i<paperSpawn; i++)
        {
            float randomX = Random.Range(-15f, 15f);
            float randomY = Random.Range(-8f, 8f);

            Vector3 spawnPosition = maps.transform.position + new Vector3(randomX, randomY);

            Instantiate(paper, spawnPosition, Quaternion.identity);
        }
    }
    void scissorsSpanwner()
    {
        for(int i = 0; i<scissorsSpawn; i++)
        {
            float randomX = Random.Range(-15f, 15f);
            float randomY = Random.Range(-8f, 8f);

            Vector3 spawnPosition = maps.transform.position + new Vector3(randomX, randomY);

            Instantiate(scissors, spawnPosition, Quaternion.identity);
        }
    }
}
