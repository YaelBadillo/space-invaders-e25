using UnityEngine;

/// <summary>
/// Manages the actions for the main menu.
/// </summary>
public class MainMenu : GameLauncher
{
    /// <summary>
    /// The name of the game scene.
    /// </summary>
    protected override int GameSceneName => SceneBuildIndexes.GameScene;

    /// <summary>
    /// Quits the game.
    /// </summary>
    public void Quit()
    {
        Application.Quit();
    }
}
