using UnityEngine;

/// <summary>
/// This script is used to pause and resume the game.
/// </summary>
public class PauseGame : MonoBehaviour
{
    /// <summary>
    /// Indicates if the game is paused.
    /// </summary>
    bool _isPaused = false;
    public bool IsPaused => _isPaused;

    /// <summary>
    /// Pauses or resumes the game.
    /// </summary>
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

    /// <summary>
    /// Pauses the game.
    /// </summary>
    public void Pause()
    {
        TimeManager.StopTimeScale();
        _isPaused = true;
    }

    /// <summary>
    /// Resumes the game.
    /// </summary>
    public void Resume()
    {
        TimeManager.ResumeTimeScale();
        _isPaused = false;
    }
}
