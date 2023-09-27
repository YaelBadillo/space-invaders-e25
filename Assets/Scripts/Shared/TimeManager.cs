using UnityEngine;

public class TimeManager : MonoBehaviour
{
    static public void StopTimeScale()
    {
        Time.timeScale = 0f;
    }

    static public void ResumeTimeScale()
    {
        Time.timeScale = 1f;
    }
}
