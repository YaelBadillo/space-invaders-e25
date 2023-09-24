using UnityEngine;

public class SinusoidalMovementX : MonoBehaviour
{
    [SerializeField] private float cycleAnchor;
    [SerializeField] private float frequency;
    [SerializeField] private float delay;

    private float xPosition, sinCounter, xSin;

    void Start()
    {
        xPosition = transform.position.x;
    }

    void Update()
    {
        if (Time.timeScale == 0f)
        {
            return;
        }

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
