using UnityEngine;

public class DeathManager : MonoBehaviour
{
    [SerializeField] private GameObject gameOverMenu;

    public void Death()
    {
        gameOverMenu.SetActive(true);
        Destroy(gameObject);
    }
}
