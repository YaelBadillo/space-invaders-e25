using UnityEngine;

/// <summary>
/// This script is used to manage the player's shot.
/// </summary>
public class PlayerShot : Shot
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
