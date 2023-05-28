using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static void SaveLevel()
    {
        PlayerPrefs.SetInt("level", LevelController.level);
    }

    public static void ClearLevel()
    {
        PlayerPrefs.SetInt("level", 1);
    }
}
