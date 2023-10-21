using UnityEngine;

/// <summary>
/// Use to stop and resume the time scale for pause and resume the game.
/// </summary>
public class TimeManager : MonoBehaviour
{
    /// <summary>
    /// Stops the time scale.
    /// </summary>
    static public void StopTimeScale()
    {
        Time.timeScale = 0f;
    }

    /// <summary>
    /// Resumes the time scale.
    /// </summary>
    static public void ResumeTimeScale()
    {
        Time.timeScale = 1f;
    }
}
