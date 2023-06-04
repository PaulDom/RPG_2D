using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrows : MonoBehaviour
{
    public float speed = 1;
    public int arrows_damage = 1;

    private void Start()
    {
        Destroy(gameObject, 5f);
        arrows_damage = PlayerPrefs.GetInt("arrows_damage", 1);
    }

    void Update()
    {
        transform.position += transform.up * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy enemyScript = collision.GetComponent<Enemy>();
            enemyScript.TakeDamage(arrows_damage);
            print("Мы нанесли врагу" + arrows_damage + "урона стрелой");
            Destroy(gameObject);
        }
    }

}
