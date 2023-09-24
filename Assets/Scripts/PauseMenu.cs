using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] private GameObject pauseMenu;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OpenCloseMenu();
        }
    }

    private void OpenCloseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }
}
