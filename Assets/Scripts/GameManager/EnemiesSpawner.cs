using UnityEngine;

/// <summary>
/// This script is used to spawn enemies.
/// </summary>
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
    /// <summary>
    /// Container for all row of enemies.
    /// </summary>
    [SerializeField]
    GameObject enemiesContainer;

    /// <summary>
    /// Initial number of enemy rows.
    /// </summary>
    int rows = 2;

    /// <summary>
    /// Initial number of enemies per row.
    /// </summary>
    int numberOfEnemiesPerRow = 2;

    int numberOfWaves = 0;

    float difficultyIndex = 1f;

    void Start()
    {
        GenerateEnemies();
    }

    void Update()
    {
        bool hasChildren = false;
        if (enemiesContainer.transform.childCount > 0)
        {
            hasChildren = true;
        }

        if (!hasChildren)
        {
            enemiesContainer.GetComponent<VerticalMovement>().Reset();
            GenerateNextWave();
        }
    }

    /// <summary>
    /// Generates the next wave of enemies.
    /// </summary>
    void GenerateNextWave()
    {
        numberOfWaves++;

        if (numberOfWaves % 3 == 0 && numberOfEnemiesPerRow < 9)
        {
            numberOfEnemiesPerRow++;
        }

        if (numberOfWaves % 5 == 0 && rows < 4)
        {
            rows++;
        }

        GenerateEnemies();
        difficultyIndex += 0.2f;
    }

    /// <summary>
    /// Generates enemies.
    /// </summary>
    void GenerateEnemies()
    {
        float initialX;
        float initialY = 0f;
        for (int numberOfEnemyRow = 0; numberOfEnemyRow < rows; numberOfEnemyRow++)
        {
            initialX = -4f;
            for (int numberOfEnemy = 0; numberOfEnemy < numberOfEnemiesPerRow; numberOfEnemy++)
            {
                GameObject enemy = null;
                if (numberOfEnemyRow == 0)
                {
                    enemy = Instantiate(alien, enemiesContainer.transform);
                }
                else if (numberOfEnemyRow == 1)
                {
                    enemy = Instantiate(snail, enemiesContainer.transform);
                }
                else if (numberOfEnemyRow == 2)
                {
                    enemy = Instantiate(ant, enemiesContainer.transform);
                }
                else if (numberOfEnemyRow == 3)
                {
                    enemy = Instantiate(fly, enemiesContainer.transform);
                }

                if (enemy != null)
                {
                    enemy.transform.localPosition = new Vector2(initialX, initialY);

                    enemy.GetComponent<EnemyMovement>().Velocity *= difficultyIndex;
                    enemy.GetComponent<EnemyShot>().MaxShootEverySeconds /= difficultyIndex - 0.1f;
  
                    initialX++;
                }

            }
            initialY++;
        }
    }
}
