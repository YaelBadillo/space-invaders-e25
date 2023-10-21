using UnityEngine;

/// <summary>
/// Base class for all entities.
/// </summary>
public abstract class Entity : MonoBehaviour
{
    /// <summary>
    /// The life/endurance of the entity.
    /// </summary>
    protected abstract float Existence { get; set; }
    /// <summary>
    /// The value of death.
    /// </summary>
    protected readonly float death = 0;

    /// <summary>
    /// Called to take damage.
    /// </summary>
    /// <param name="damage"></param>
    public virtual void TakeDamage(float damage)
    {
        Existence -= damage;
        if (Existence <= death)
        {
            Destroy(gameObject);
        }
    }
}
