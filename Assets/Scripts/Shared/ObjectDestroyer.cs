using UnityEngine;

/// <summary>
/// This script is used to destroy the game objects.
/// </summary>
public class ObjectDestroyer : MonoBehaviour
{
    /// <summary>
    /// Destroys the game object.
    /// </summary>
    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}