using UnityEngine;

public class PauseGame : MonoBehaviour
{
    bool _isPaused = false;
    public bool IsPaused => _isPaused;

    public void PauseResume()
    {
        if (_isPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

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
