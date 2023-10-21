using UnityEngine;

/// <summary>
/// This script is used to move a row of enemies in a sinusoidal pattern on the x-axis.
/// </summary>
public class SinusoidalMovementX : MonoBehaviour
{
    /// <summary>
    /// The amount of units the object will move on the x-axis.
    /// </summary>
    [SerializeField] private float cycleAnchor;
    /// <summary>
    /// The frequency of the sinusoidal movement. 
    /// </summary>
    [SerializeField] private float frequency;
    /// <summary>
    /// The delay before the object starts moving.
    /// </summary>
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
