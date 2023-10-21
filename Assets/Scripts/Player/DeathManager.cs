using UnityEngine;

/// <summary>
/// This script is used to manage the death of the player.
/// </summary>
public class DeathManager : MonoBehaviour
{
    /// <summary>
    /// The game over menu.
    /// </summary>
    [SerializeField] private GameObject gameOverMenu;

    /// <summary>
    /// Called when the player dies.
    /// </summary>
    public void Death()
    {
        gameOverMenu.SetActive(true);
        Destroy(gameObject);
    }
}
