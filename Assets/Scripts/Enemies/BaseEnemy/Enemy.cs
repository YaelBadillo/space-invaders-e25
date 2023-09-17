using UnityEngine;

public class Enemy : Entity
{
    [SerializeField] private float life = 2f;
    protected override float Existence
    {
        get { return life; }
        set { life = value; }
    }
}
