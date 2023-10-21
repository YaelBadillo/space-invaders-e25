using UnityEngine;

/// <summary>
/// This script is used to move down all enemy rows.
/// </summary>
public class VerticalMovement : MonoBehaviour
{
    /// <summary>
    /// The destination of the enemies.
    /// </summary>
    [SerializeField] private Vector2 destination;
    /// <summary>
    /// The velocity of the move.
    /// </summary>
    [SerializeField] private float velocity = 5.0f;
    private Rigidbody2D objectRigidbody2D;
    /// <summary>
    /// A boolean to check if the enemies have arrived at their destination.
    /// </summary>
    private bool hasArrived = false;

    void Start()
    {
        objectRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (!hasArrived)
        {
            Move();
        }
    }

    /// <summary>
    /// Moves the enemies to their destination.
    /// </summary>
    void Move()
    {
        Vector2 direction = (destination - objectRigidbody2D.position).normalized;

        objectRigidbody2D.velocity = direction * velocity;
        if (Vector2.Distance(objectRigidbody2D.position, destination) < 0.1f)
        {
            hasArrived = true;
            objectRigidbody2D.velocity = Vector2.zero;
        }
    }

    /// <summary>
    /// Resets the enemies to their starting position.
    /// </summary>
    public void Reset()
    {
        hasArrived = false;
        objectRigidbody2D.position = new Vector2(9f, 9f);
        gameObject.transform.position = new Vector2(9f, 9f);
    }
}
