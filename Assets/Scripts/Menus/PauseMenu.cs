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
        PauseResumeGame();
    }

    private void PauseResumeGame()
    {
        if (pauseMenu.activeSelf)
        {
            GetComponent<GameManager>().Pause();
        }
        else
        {

            GetComponent<GameManager>().Resume();
        }
    }
}
