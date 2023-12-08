using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    GameObject enemiesContainer;

    private bool _isMovingToTheRight = true;

    private bool IsMovingToTheRight
    {
        get { return _isMovingToTheRight; }
        set { _isMovingToTheRight = value; }
    }

    private Vector2 _direction = Vector2.right;

    private Vector2 Direction
    {
        get { return _direction; }
        set { _direction = value; }
    }

    [SerializeField] private float _velocity = 5.0f;
    private float Velocity
    {
        get { return _velocity; }
        set { _velocity = value; }
    }

    private float leftLimit;
    private float rightLimit;

    void Start()
    {
        enemiesContainer = transform.parent.gameObject;

        leftLimit = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0)).x;
        rightLimit = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0)).x;
    }

    void Update()
    {
        transform.Translate(Velocity * Time.deltaTime * Direction);

        if (transform.position.x < leftLimit || transform.position.x > rightLimit)
        {
            for (int enemiesIndex = 0; enemiesIndex < enemiesContainer.transform.childCount; enemiesIndex++)
            {
                Transform currentEnemy = enemiesContainer.transform.GetChild(enemiesIndex);

                EnemyMovement currentEnemyMovement = currentEnemy.GetComponent<EnemyMovement>();

                Vector2 currentEnemyDirection = currentEnemyMovement.Direction;
                bool isCurrentEnemyMovingToTheRight = currentEnemyMovement.IsMovingToTheRight;
                if (isCurrentEnemyMovingToTheRight == false && currentEnemyDirection == Vector2.left)
                {
                    currentEnemyMovement.Direction = Vector2.right;
                    currentEnemyMovement.IsMovingToTheRight = true;
                }
                else if (isCurrentEnemyMovingToTheRight == true && currentEnemyDirection == Vector2.right)
                {
                    currentEnemyMovement.Direction = Vector2.left;
                    currentEnemyMovement.IsMovingToTheRight = false;
                }
            }
        }
    }
}
