using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Manages the actions for the game manu
/// </summary>
public abstract class GameLauncher : MonoBehaviour
{
    /// <summary>
    /// The name of the game scene.
    /// </summary>
    protected abstract int GameSceneName { get; }

    /// <summary>
    /// Starts the game.
    /// </summary>
    public void StartGame()
    {
        TimeManager.ResumeTimeScale();

        SceneManager.LoadScene(GameSceneName);
    }
}
