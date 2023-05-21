using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public Spawner spawnerScript;
    public static bool finished = false;
    public static int level = 1;

    private void Start()
    {
        finished = false;
    }

    private void Update()
    {
        if (finished == false)
        {
            Check();
        }
    }

    private void Check()
    {
        if (spawnerScript.spawnCounter <= 0)
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();
            if (enemies.Length == 0)
            {
                Victory();
            }
        }

        if (Corn.singleton.health <= 0)
        {
            Defeat();
        }
    }

    private void Victory()
    {
        print("Win");
        finished = true;
        level++;
    }

    private void Defeat()
    {
        print("Defeat");
        finished = true;
        level = 1;
    }
}
