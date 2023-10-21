using UnityEngine;

/// <summary>
/// Base class to manage the bullets
/// </summary>
public abstract class Bullet : MonoBehaviour
{
    /// <summary>
    /// The velocity of the bullet.
    /// </summary>
    [SerializeField] protected float velocity = 5f;
    /// <summary>
    /// The damage of the bullet.
    /// </summary>
    [SerializeField] protected float damage = 2f;
    /// <summary>
    /// The direction of the bullet.
    /// </summary>
    protected abstract Vector2 Direction { get; }

    public void Update()
    {
        transform.Translate(Time.deltaTime * velocity * Direction);
    }

    /// <summary>
    /// Called when the bullet collides with other entity.
    /// </summary>
    /// <param name="other"></param>
    public abstract void OnTriggerEnter2D(Collider2D other);

    public void Collides(Collider2D other)
    {
        Destroy(gameObject);
        other.GetComponent<Entity>().TakeDamage(damage);
    }
}
