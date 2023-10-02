using UnityEngine;

public class EnemiesSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject alien;
    [SerializeField]
    GameObject snail;
    [SerializeField]
    GameObject ant;
    [SerializeField]
    GameObject fly;
    [SerializeField]
    GameObject enemiesContainer;
    float initialX = -4f;
    float initialY = 0f;
    float initialZ = 0f;

    void Start()
    {
        int childCount = enemiesContainer.transform.childCount;
        for (int numberOfEnemyRow = 0; numberOfEnemyRow < childCount; numberOfEnemyRow++)
        {
            Transform enemyRow = enemiesContainer.transform.GetChild(numberOfEnemyRow);
            initialX = -4f;
            for (int numberOfEnemy = 0; numberOfEnemy < 9; numberOfEnemy++)
            {
                GameObject enemy = null;
                if (numberOfEnemyRow == 0)
                {
                    enemy = Instantiate(alien, enemyRow);
                }

                if (numberOfEnemyRow == 1)
                {
                    enemy = Instantiate(snail, enemyRow);
                }

                if (numberOfEnemyRow == 2)
                {
                    enemy = Instantiate(ant, enemyRow);
                }

                if (numberOfEnemyRow == 3)
                {
                    enemy = Instantiate(fly, enemyRow);
                }

                enemy.transform.localPosition = new Vector3(initialX, initialY, initialZ);
                initialX++;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
