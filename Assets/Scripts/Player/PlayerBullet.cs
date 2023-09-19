using UnityEngine;

public class PlayerBullet : Bullet
{
    protected override Vector2 Direction => Vector2.up;

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag(EntityTags.Enemy))
        {
            Collides(other);
        }
    }
}
