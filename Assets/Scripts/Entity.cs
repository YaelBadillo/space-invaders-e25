using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    protected abstract float Existence { get; set; }
    private readonly float death = 0;

    public void TakeDamage(float damage) {
        Existence -= damage;
        if (Existence <= death) {
            Destroy(gameObject);
        }
    }
}
