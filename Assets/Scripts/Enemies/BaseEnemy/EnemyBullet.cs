using UnityEngine;

public class EnemyBullet : Bullet
{
    protected override Vector2 Direction => Vector2.down;

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Destroy(gameObject);
            other.GetComponent<Player>().TakeDamage(damage);
        }

        if (other.CompareTag("Obstacle"))
        {
            Destroy(gameObject);
            other.GetComponent<Obstacle>().TakeDamage(damage);
        }
    }
}
