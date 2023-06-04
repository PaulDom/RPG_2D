using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corn : MonoBehaviour
{
    public static Corn singleton;
    public int health;
    public int crystals = 0;

    public int initHealth = 5;
    public int healthPerUpgrade;

    private void Awake()
    {
        singleton = this;
        crystals = PlayerPrefs.GetInt("crystals", 0);
        int healthBonus = healthPerUpgrade * PlayerPrefs.GetInt("healthUp", 0);
        health = initHealth + healthBonus;
        AddCrystals(10);
    }

    public void AddCrystals(int count_crystal)
    {
        crystals += count_crystal;
        GameController.SaveCrystals();
    }


    public void SpendCrystals(int count_crystal)
    {
        crystals -= count_crystal;
        GameController.SaveCrystals();
    }

    public void TakeDamage()
    {
        if (health > 0)
        {
            health--;
        }
    }

}
