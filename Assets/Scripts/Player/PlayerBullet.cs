using UnityEngine;

/// <summary>
/// This script is used to manage the player's bullets.
/// </summary>
public class PlayerBullet : Bullet
{
    /// <summary>
    /// The direction of the bullets.
    /// </summary>
    protected override Vector2 Direction => Vector2.up;

    /// <summary>
    /// Called when the bullet collides with other entity.
    /// </summary>
    /// <param name="other"></param>
    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(EntityTags.Enemy))
        {
            Collides(other);
        }
    }
}
