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

    int rows = 2;
    int numberOfEnemiesPerRow = 2;

    void Start()
    {
        GenerateEnemies();
    }

    void Update()
    {
        bool hasChildren = false;
        foreach (Transform enemyRow in enemiesContainer.transform)
        {
            if (enemyRow.childCount > 0)
            {
                hasChildren = true;
                break;
            }
        }

        if (!hasChildren)
        {
            enemiesContainer.GetComponent<VerticalMovement>().Reset();
            GenerateNextWave();
            GenerateEnemies();
        }
    }

    void GenerateNextWave()
    {
        if (numberOfEnemiesPerRow < 9)
        {
            numberOfEnemiesPerRow++;
        }

        if (numberOfEnemiesPerRow % 3 == 0 && rows < 4)
        {
            rows++;
        }

        GenerateEnemies();
    }

    void GenerateEnemies()
    {
        float initialX;
        float initialY = 0f;
        float initialZ = 0f;

        for (int numberOfEnemyRow = 0; numberOfEnemyRow < rows; numberOfEnemyRow++)
        {
            Transform enemyRow = enemiesContainer.transform.GetChild(numberOfEnemyRow);
            initialX = -4f;
            for (int numberOfEnemy = 0; numberOfEnemy < numberOfEnemiesPerRow; numberOfEnemy++)
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
}
