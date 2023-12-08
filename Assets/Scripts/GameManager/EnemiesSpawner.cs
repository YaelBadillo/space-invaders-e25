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
            GenerateEnemies();
        }
    }

    /// <summary>
    /// Generates the next wave of enemies.
    /// </summary>
    void GenerateNextWave()
    {
        if (numberOfEnemiesPerRow < 9)
        {
            numberOfEnemiesPerRow++;
        }

        if (numberOfEnemiesPerRow % 2 == 0 && rows < 4)
        {
            rows++;
        }

        GenerateEnemies();
    }

    /// <summary>
    /// Generates enemies.
    /// </summary>
    void GenerateEnemies()
    {
        float initialX;
        float initialY = 0f;
        float initialZ = 0f;

        for (int numberOfEnemyRow = 0; numberOfEnemyRow < rows; numberOfEnemyRow++)
        {
            initialX = -4f;
            for (int numberOfEnemy = 0; numberOfEnemy < numberOfEnemiesPerRow; numberOfEnemy++)
            {
                GameObject enemy = Instantiate(alien, enemiesContainer.transform);

                enemy.transform.localPosition = new Vector3(initialX, initialY, initialZ);
                initialX++;
            }
            initialY++;
        }
    }
}
