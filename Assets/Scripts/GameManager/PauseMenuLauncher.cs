using UnityEngine;

public class PauseMenuLauncher : MonoBehaviour
{
    [SerializeField]
    GameObject pauseMenu;

    public void OpenCloseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }
}
