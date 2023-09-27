using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class GameLauncher : MonoBehaviour
{
    protected abstract int GameSceneName { get; }

    public void StartGame()
    {
        TimeManager.ResumeTimeScale();

        SceneManager.LoadScene(GameSceneName);
    }
}
