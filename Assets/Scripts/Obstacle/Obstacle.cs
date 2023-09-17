using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : Entity
{
    [SerializeField] private float endurance = 6f;

    protected override float Existence
    {
        get { return endurance; }
        set { endurance = value; }
    }
}
