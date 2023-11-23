using System.Collections;
using UnityEngine;

/// <summary>
/// Base class for all enemy shots.
/// </summary>
public class EnemyShot : Shot
{
    void Start()
    {
        float secondsBeforeStartShooting = Random.Range(0f, 10f);

        Invoke(nameof(StartFire), secondsBeforeStartShooting);
    }

    /// <summary>
    /// Start shooting.
    /// </summary>
    private void StartFire()
    {
        StartCoroutine(FireEveryFewSeconds());
    }

    /// <summary>
    /// Shoot.
    /// </summary>
    /// <returns></returns>
    private IEnumerator FireEveryFewSeconds()
    {
        float shootEverySeconds;
        while (true)
        {
            Shoot();
            shootEverySeconds = Random.Range(0.5f, 5f);
            yield return new WaitForSeconds(shootEverySeconds);
        }
    }
}
