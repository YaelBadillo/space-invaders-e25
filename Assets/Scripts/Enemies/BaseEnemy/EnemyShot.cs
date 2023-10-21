using System.Collections;
using UnityEngine;

/// <summary>
/// Base class for all enemy shots.
/// </summary>
public class EnemyShot : Shot
{
    /// <summary>
    /// The seconds between each shot.
    /// </summary>
    private float shootEverySeconds;

    void Start()
    {
        System.Random random = new System.Random();
        float secondsBeforeStartShooting = (float)(random.NextDouble() * 10f);
        shootEverySeconds = (float)(random.NextDouble() * 10f);


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
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(shootEverySeconds);
        }
    }
}
