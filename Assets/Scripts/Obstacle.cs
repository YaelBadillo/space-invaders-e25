using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private float endurance;

    public void TakeDamage(float damage)
    {
        endurance -= damage;
        if (endurance <= 0f)
        {
            Destroy(gameObject);
        }
    }
}
