using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 0.5f;
    public int health = 4;

    public void TakeDamage()
    {
        health -= 1;

        if (health == 0)
        {
            Destroy(gameObject);
        }
    }
    
    public void Update()
    {
         transform.position += -transform.right* speed * Time.deltaTime;
    }
}
