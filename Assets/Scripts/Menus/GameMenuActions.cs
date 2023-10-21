using UnityEngine.SceneManagement;

/// <summary>
/// Manages the menu actions.
/// </summary>
public class GameMenuActions : GameLauncher
{
    /// <summary>
    /// The name of the game scene.
    /// </summary>
    protected override int GameSceneName => SceneBuildIndexes.GameScene;

    /// <summary>
    /// Back to the home menu.
    /// </summary>
    public void BackToHome()
    {
        SceneManager.LoadScene(SceneBuildIndexes.GameMenu);
    }
}
