using UnityEngine;

/// <summary>
/// This script is used to manage the obstacles.
/// </summary>
public class Obstacle : Entity
{
    /// <summary>
    /// The endurance of the obstacle.
    /// </summary>
    [SerializeField] private float endurance = 6f;

    protected override float Existence
    {
        get { return endurance; }
        set { endurance = value; }
    }
}
