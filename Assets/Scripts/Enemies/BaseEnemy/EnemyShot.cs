using System.Collections;
using UnityEngine;

public class EnemyShot : Shot
{
    [SerializeField] private int seconds;

    void Start()
    {
        System.Random random = new System.Random();
        float secondsBeforeStarting = (float)(random.NextDouble() * 5f);

        Invoke(nameof(StartFire), secondsBeforeStarting);
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
            yield return new WaitForSeconds(seconds);
        }
    }
}
