using UnityEngine;

/// <summary>
/// Base class for all enemies.
/// </summary>
public class Enemy : Entity
{
    [SerializeField] private float life = 2f;

    /// <summary>
    /// The life of the enemy.
    /// </summary>
    protected override float Existence
    {
        get { return life; }
        set { life = value; }
    }
}
