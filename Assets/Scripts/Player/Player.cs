using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float life;
    [SerializeField] private int lives;
    [SerializeField] private GameObject liveSprites;

    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0f)
        {
            ToRevive();
            lives--;
            Transform live = liveSprites.transform.GetChild(0);
            Destroy(live.gameObject);
        }
    }

    private void ToRevive() {
        transform.position = new Vector3(0f, transform.position.y);
    }
}
