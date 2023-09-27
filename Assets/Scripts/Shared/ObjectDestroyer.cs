using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}