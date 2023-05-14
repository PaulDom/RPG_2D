using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 directionMove;
    private float cornPosX;
    public float speed = 1;
    public int health = 4;
    public Animator animator;

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

    private void Update()
    {
        float enemyPosX = transform.position.x;

        if (enemyPosX > cornPosX)
        {
            animator.SetBool("isMoving", true);
            transform.position += directionMove* speed * Time.deltaTime;
        } 
        else
        {
            animator.SetBool("isMoving", false);
        }
    }
}
