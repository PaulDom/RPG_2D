using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.5f;
    private float cornPosX;
    public int health = 4;
    public Animator animator;
    public float shootInterval = 1f;
    public float shootTimer = 1f;

    public void TakeDamage()
    {
        health -= 1;

        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    
    private void Start()
    {
        cornPosX = Corn.singleton.transform.position.x;
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
            transform.position += -transform.right* speed * Time.deltaTime;
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
