using UnityEngine;

/// <summary>
/// This script is used to launch the pause menu.
/// </summary>
public class PauseMenuLauncher : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;

    /// <summary>
    /// Opens or closes the pause menu.
    /// </summary>
    public void OpenCloseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }
}
