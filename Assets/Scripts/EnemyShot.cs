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
