using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
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
    }
}
