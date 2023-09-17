using System.Collections;
using System.Collections.Generic;
using UnityEditor.Callbacks;
using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    public Vector2 destination;
    public float velocity = 5.0f;
    Rigidbody2D objectRigidbody2D;
    bool hasArrived = false;

    void Start()
    {
        objectRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!hasArrived)
        {
            Vector2 direction = (destination - objectRigidbody2D.position).normalized;

            objectRigidbody2D.velocity = direction * velocity;
            if (Vector2.Distance(objectRigidbody2D.position, destination) < 0.1f)
            {
                hasArrived = true;
                objectRigidbody2D.velocity = Vector2.zero;
            }

        }
    }
}
