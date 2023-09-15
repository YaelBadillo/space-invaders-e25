using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalMovementX : MonoBehaviour
{
    public float cycleAnchor;
    public float frequency;
    public float delay;

    float xPosition, sinCounter, xSin;

    void Start()
    {
        xPosition = transform.position.x;
    }

    void Update()
    {
        if (delay > 0)
        {
            delay--;
            return;
        }

        sinCounter += frequency / 100;
        xSin = Mathf.Sin(sinCounter);

        transform.position = new Vector2(xPosition + (xSin * cycleAnchor), transform.position.y);
        if (sinCounter > 6.28f)
            sinCounter = 0;
    }
}
