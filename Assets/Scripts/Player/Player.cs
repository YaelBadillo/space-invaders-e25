using UnityEngine;

public class Player : Entity
{
    [SerializeField] private float life = 2f;
    [SerializeField] private int lives = 3;
    [SerializeField] private GameObject liveSprites;
    protected override float Existence
    {
        get { return life; }
        set { life = value; }
    }

    public override void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0f)
        {
            LoseALife();
        }

        if (lives < 0)
        {
            GetComponent<DeathManager>().Death();
        }
    }

    private void LoseALife()
    {
        ToRevive();
        lives--;
        if (liveSprites.transform.childCount > 0)
        {

            Transform live = liveSprites.transform.GetChild(0);
            Destroy(live.gameObject);
        }
    }

    private void ToRevive()
    {
        transform.position = new Vector3(0f, transform.position.y);
    }
}
