using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected abstract float Existence { get; set; }
    protected readonly float death = 0;

    public virtual void TakeDamage(float damage)
    {
        Existence -= damage;
        if (Existence <= death)
        {
            Destroy(gameObject);
        }
    }
}
