using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    [SerializeField] private float velocity;
    [SerializeField] private float damage;

    void Update()
    {
        transform.Translate(Vector2.down * velocity * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other)
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
