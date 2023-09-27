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
        TimeManager.StopTimeScale();
        _isPaused = true;
    }

    public void Resume()
    {
        TimeManager.ResumeTimeScale();
        _isPaused = false;
    }
}
