using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullet : Bullet
{
    protected override Vector2 Direction => Vector2.up;

    public override void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            other.GetComponent<Enemy>().TakeDamage(damage);
        }
    }
}
