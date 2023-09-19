using UnityEngine;

public class EnemyBullet : Bullet
{
    protected override Vector2 Direction => Vector2.down;

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
