using UnityEngine;

public class VerticalMovement : MonoBehaviour
{
    [SerializeField] private Vector2 destination;
    [SerializeField] private float velocity = 5.0f;
    private Rigidbody2D objectRigidbody2D;
    private bool hasArrived = false;

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
