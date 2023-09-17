using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shot : MonoBehaviour
{
    [SerializeField] protected Transform shotHandler;
    [SerializeField] protected GameObject bullet;

    protected void Shoot()
    {
        Instantiate(bullet, shotHandler.position, shotHandler.rotation);
    }
}
