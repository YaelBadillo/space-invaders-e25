using UnityEngine;

public abstract class Bullet : MonoBehaviour
{
    [SerializeField] protected float velocity = 5f;
    [SerializeField] protected float damage = 2f;
    protected abstract Vector2 Direction { get; }

    public void Update()
    {
        transform.Translate(Time.deltaTime * velocity * Direction);
    }

    public abstract void OnTriggerEnter2D(Collider2D other);
}
