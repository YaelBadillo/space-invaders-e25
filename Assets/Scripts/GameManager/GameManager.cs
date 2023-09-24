using UnityEngine;

public class GameManager : MonoBehaviour
{
    private bool _isPaused = false;
    public bool IsPaused => _isPaused;

    public void Pause()
    {
        Time.timeScale = 0f;
        _isPaused = true;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        _isPaused = false;
    }
}
