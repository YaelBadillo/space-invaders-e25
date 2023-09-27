using UnityEngine;

public class MainMenu : GameLauncher
{
    protected override int GameSceneName => SceneBuildIndexes.GameScene;

    public void Quit()
    {
        Application.Quit();
    }
}
