using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuActions : MonoBehaviour
{
    public void Restart()
    {
        TimeManager.ResumeTimeScale();
        int gameScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(gameScene);
    }

    public void BackToHome()
    {
        int homeScene = SceneManager.GetActiveScene().buildIndex - 1;
        SceneManager.LoadScene(homeScene);
    }
}
