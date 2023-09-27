using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        TimeManager.ResumeTimeScale();

        int gameScene = SceneManager.GetActiveScene().buildIndex + 1;
        SceneManager.LoadScene(gameScene);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
