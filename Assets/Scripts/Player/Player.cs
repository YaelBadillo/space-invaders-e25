using UnityEngine;

/// <summary>
/// This script is used to manage the player.
/// </summary>
public class Player : Entity
{
    /// <summary>
    /// The life of the player.
    /// </summary>
    [SerializeField] private float life = 2f;
    protected override float Existence
    {
        get { return life; }
        set { life = value; }
    }
    /// <summary>
    /// The lives manager.
    /// </summary>
    private LivesManager livesManager;

    void Start()
    {
        livesManager = GetComponent<LivesManager>();
    }

    /// <summary>
    /// Called to take damage.
    /// </summary>
    /// <param name="damage"></param>
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
