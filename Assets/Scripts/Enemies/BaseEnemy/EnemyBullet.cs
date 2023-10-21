using UnityEngine;

/// <summary>
/// Base class for all enemy bullets.
/// </summary>
public class EnemyBullet : Bullet
{
    /// <summary>
    /// The direction of the bullet.
    /// </summary>
    protected override Vector2 Direction => Vector2.down;

    /// <summary>
    /// This manage collides with the Player or and obstacle. 
    /// </summary>
    /// <param name="other"></param>
    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(EntityTags.Player))
        {
            Collides(other);
        }

        if (other.CompareTag(EntityTags.Obstacle))
        {
            Collides(other);
        }
    }
}
