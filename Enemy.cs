using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 directionMove;
    private float cornPosX;
    public float speed = 1;
    public float speedPerLevel = 0.2f;
    public int health = 4;
    public Animator animator;

    public float shootInterval = 1f;
    public float shootTimer = 1f;

    public int price_for_kill = 2;

    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            Die();
        }
    }
    
    public void Die()
    {
        Corn.singleton.AddCrystals(price_for_kill);
        Destroy(gameObject);
    }

    private void Start()
    {
        cornPosX = Corn.singleton.transform.position.x;
        speed += speedPerLevel * LevelController.level;
    }

    public void Attack()
    {
        Corn.singleton.TakeDamage();
    }

    private void Update()
    {
        shootTimer += Time.deltaTime;

        float enemyPosX = transform.position.x;

        if (enemyPosX > cornPosX)
        {
            animator.SetBool("isMoving", true);
            transform.position += directionMove* speed * Time.deltaTime;
        } 
        else
        {
            animator.SetBool("isMoving", false);
            if (shootTimer >= shootInterval)
            {
                Attack();
                shootTimer = 0;
            }
        }
    }
}
