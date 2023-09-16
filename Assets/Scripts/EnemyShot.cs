using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShot : MonoBehaviour
{
    [SerializeField] private Transform shotHandler;
    [SerializeField] private GameObject bullet;
    [SerializeField] private int seconds;

    void Start()
    {
        System.Random random = new System.Random();
        float secondsBeforeStarting = (float)(random.NextDouble() * 5f);

        Invoke("StartFire", secondsBeforeStarting);
    }

    private void StartFire()
    {
        StartCoroutine(FireEveryFewSeconds());
    }

    private IEnumerator FireEveryFewSeconds()
    {
        while (true)
        {
            Shot();
            yield return new WaitForSeconds(seconds);
        }
    }

    private void Shot()
    {
        Instantiate(bullet, shotHandler.position, shotHandler.rotation);
    }
}
