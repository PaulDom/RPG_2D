using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Vector3 directionMove;
    public float speed = 1;
    public int health = 4;

    public void TakeDamage()
    {
        health -= 1;

        if (health == 0)
        {
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        transform.position += directionMove* speed * Time.deltaTime;
    }
}
