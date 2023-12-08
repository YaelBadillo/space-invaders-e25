using UnityEngine;

/// <summary>
/// Base class to manage the shots.
/// </summary>
public abstract class Shot : MonoBehaviour
{
    /// <summary>
    /// The shot handler.
    /// </summary>
    [SerializeField] protected Transform shotHandler;
    /// <summary>
    /// The shot prefab.
    /// </summary>
    [SerializeField] protected GameObject bullet;

    protected AudioSource audioSource;

    /// <summary>
    /// Called to shoot.
    /// </summary>
    protected void Shoot()
    {
        Instantiate(bullet, shotHandler.position, shotHandler.rotation);
        if (audioSource)
        {
            audioSource.Play();
        }
    }
}
