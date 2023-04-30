using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public GameObject arrowPrefab;
    public float shootInterval = 0.75f;
    public float shootTimer = 0;

    void Update()
    {
        Vector2 mouseScreenPos = Input.mousePosition;
        Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

        Vector2 crossbowPos = transform.position;
        Vector2 wantedDirection = mouseScenePos - crossbowPos;
        Vector2 defaultDirection = Vector2.up;

        float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);
        Vector3 newEuler = new Vector3(0, 0, angle);

        transform.localEulerAngles = newEuler;

        shootTimer += Time.deltaTime;

        if (Input.GetMouseButton(0))
        {
            if (shootTimer >= shootInterval)
            {
                Instantiate(arrowPrefab, transform.position, transform.rotation);
                shootTimer = 0;
            }    
        }
    }
}
