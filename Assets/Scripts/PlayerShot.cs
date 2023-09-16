using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShot : MonoBehaviour
{
    [SerializeField] private Transform shotHandler;
    [SerializeField] private GameObject bullet;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shot();
        }
    }

    private void Shot()
    {
        Instantiate(bullet, shotHandler.position, shotHandler.rotation);
    }
}
