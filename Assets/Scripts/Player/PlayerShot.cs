using UnityEngine;

/// <summary>
/// This script is used to manage the player's shot.
/// </summary>
public class PlayerShot : Shot
{
    void Start()
    {
        audioSource = shotHandler.GetComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
