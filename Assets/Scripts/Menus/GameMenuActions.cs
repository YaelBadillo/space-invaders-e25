using UnityEngine.SceneManagement;

public class GameMenuActions : GameLauncher
{
    protected override int GameSceneName => SceneBuildIndexes.GameScene;

    public void BackToHome()
    {
        SceneManager.LoadScene(SceneBuildIndexes.GameMenu);
    }
}
