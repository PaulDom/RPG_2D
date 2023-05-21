using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Enemy enemyPrefab;

    public Transform topBorder;
    public Transform bottomBorder;

    public float spawnTimer = 0f;

    public float spawnIntervalMax = 3.5f;
    public float spawnIntervalMin = 1f;

    public int spawnCounter = 10;
    public int spawnAddPerLevel = 5;

    private void Start()
    {
        spawnCounter += spawnAddPerLevel * LevelController.level;
    }


    private void Update()
    {
        if (LevelController.finished == false)
        {
            if (spawnTimer > 0)
            {
                spawnTimer -= Time.deltaTime;
            }
            else if (spawnCounter > 0)
            {
                Spawn();
                spawnCounter--;
                spawnTimer = Random.Range(spawnIntervalMin, spawnIntervalMax);           
            } 


        }             
    }

    private void Spawn()
    {
        Vector2 posSpawn = new Vector2(transform.position.x, Random.Range(bottomBorder.position.y, topBorder.position.y));
        Instantiate(enemyPrefab, posSpawn, Quaternion.identity);
    }
}
