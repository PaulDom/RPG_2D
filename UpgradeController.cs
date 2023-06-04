using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeController : MonoBehaviour
{
    public int healthGradePrice;
    public static int healthGrade;
    public Text healthGradePriceText;

    public int arrowsDamagePrice;
    public static int arrowsDamageGrade;
    public Text arrowsDamageGradePriceText;

    private void Update()
    {
        healthGradePriceText.text = healthGradePrice.ToString();
        arrowsDamageGradePriceText.text = arrowsDamagePrice.ToString();
    }

    public void OnClickUpgradeArrowsDamage()
    {
        if (Corn.singleton.crystals >= arrowsDamagePrice)
        {
            arrowsDamageGrade = PlayerPrefs.GetInt("arrows_damage", 1);
            arrowsDamageGrade += 1;
            GameController.SaveArrowsDamageGrade();
            Corn.singleton.SpendCrystals(arrowsDamagePrice);
        }
    }

    public void OnClickUpgradeHealth()
    {
        if (Corn.singleton.crystals >= healthGradePrice)
        {
            healthGrade = PlayerPrefs.GetInt("healthUp", 0);
            healthGrade += 1;
            GameController.SaveHealthGrade();
            Corn.singleton.SpendCrystals(healthGradePrice);
        }
    }


}
