using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public void ClearSave()
    {
        ClearLevel();
        ClearCrystals();
        ClearHealthGrade();
    }

    public static void SaveLevel()
    {
        PlayerPrefs.SetInt("level", LevelController.level);
    }

    public static void ClearLevel()
    {
        PlayerPrefs.SetInt("level", 1);
    }

    public static void SaveCrystals()
    {
        PlayerPrefs.SetInt("crystals", Corn.singleton.crystals);
    }

    public static void ClearCrystals()
    {
        PlayerPrefs.SetInt("crystals", 0);
    }

    public static void SaveHealthGrade()
    {
        PlayerPrefs.SetInt("healthUp", UpgradeController.healthGrade);
    }

    public static void ClearHealthGrade()
    {
        PlayerPrefs.SetInt("healthUP", 0);
    }

    public static void SaveArrowsDamageGrade()
    {
        PlayerPrefs.SetInt("arrows_damage", UpgradeController.arrowsDamageGrade);
    }

}
