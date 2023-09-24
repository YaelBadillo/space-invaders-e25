using UnityEngine;

public class Player : Entity
{
    [SerializeField] private float life = 2f;
    protected override float Existence
    {
        get { return life; }
        set { life = value; }
    }
    private LivesManager livesManager;

    void Start()
    {
        livesManager = GetComponent<LivesManager>();
    }

    public override void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0f)
        {
            livesManager.LoseALife();
        }

        if (livesManager.Lives < 0)
        {
            GetComponent<DeathManager>().Death();
        }
    }


}
