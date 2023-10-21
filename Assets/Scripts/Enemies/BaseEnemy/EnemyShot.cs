using System.Collections;
using UnityEngine;

public class EnemyShot : Shot
{
    private float shootEverySeconds;

    void Start()
    {
        System.Random random = new System.Random();
        float secondsBeforeStartShooting = (float)(random.NextDouble() * 10f);
        shootEverySeconds = (float)(random.NextDouble() * 10f);


        Invoke(nameof(StartFire), secondsBeforeStartShooting);
    }

    private void StartFire()
    {
        StartCoroutine(FireEveryFewSeconds());
    }

    private IEnumerator FireEveryFewSeconds()
    {
        while (true)
        {
            Shoot();
            yield return new WaitForSeconds(shootEverySeconds);
        }
    }
}
