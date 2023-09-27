using UnityEngine;

public class GameManager : MonoBehaviour
{
    PauseGame pauseGame;
    PauseMenuLauncher pauseMenuLauncher;

    void Start()
    {
        pauseGame = GetComponent<PauseGame>();
        pauseMenuLauncher = GetComponent<PauseMenuLauncher>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            pauseGame.PauseResume();
            pauseMenuLauncher.OpenCloseMenu();
        }
    }
}
