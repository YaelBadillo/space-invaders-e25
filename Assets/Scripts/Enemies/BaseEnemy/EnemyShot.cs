using System.Collections;
using UnityEngine;

/// <summary>
/// Base class for all enemy shots.
/// </summary>
public class EnemyShot : Shot
{
    float _secondsBeforeStartShooting = 0f;
    public float SecondsBeforeStartShooting
    {
        get { return _secondsBeforeStartShooting; }
        set { _secondsBeforeStartShooting = value; }
    }

    float _shootEverySeconds = 0f;
    public float ShootEverySeconds
    {
        get { return _shootEverySeconds; }
        set { _shootEverySeconds = value; }
    }

    void Start()
    {
        SecondsBeforeStartShooting = Random.Range(2f, 10f);

        Invoke(nameof(StartFire), SecondsBeforeStartShooting);
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
            ShootEverySeconds = Random.Range(0.5f, 10f);
            yield return new WaitForSeconds(ShootEverySeconds);
        }
    }
}
