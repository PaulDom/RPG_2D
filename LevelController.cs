using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{
    public Spawner spawnerScript;
    public static bool finished = false;
    public static int level = 1;

    public GameObject victoryPanel;
    public GameObject defeatPanel;

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
        victoryPanel.SetActive(true);
        finished = true;
        level++;
    }

    private void Defeat()
    {
        defeatPanel.SetActive(true);
        finished = true;
        level = 1;
    }

    public void RestartLevel()
    {
        int index = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(index);
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
