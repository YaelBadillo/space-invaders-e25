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
            Move();
        }
    }

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

    public void Reset()
    {
        hasArrived = false;
        objectRigidbody2D.position = new Vector2(9f, 9f);
        gameObject.transform.position = new Vector2(9f, 9f);
    }
}
