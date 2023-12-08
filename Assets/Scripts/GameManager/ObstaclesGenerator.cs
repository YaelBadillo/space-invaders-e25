using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour
{
    [SerializeField]
    GameObject obstaclesContainer;

    [SerializeField]
    GameObject obstaclePrefab;

    readonly int numberOfObstacles = 4;
    void Start()
    {
        Generate();
    }

    public void Generate()
    {
        obstaclesContainer.transform.DetachChildren();
        foreach (Transform child in obstaclesContainer.transform)
        {
            Destroy(child.gameObject);
        }

        float initialX = -4.5f;
        float initialY = 0;

        for (int i = 0; i < numberOfObstacles; i++)
        {
            GameObject obstacle = Instantiate(obstaclePrefab, obstaclesContainer.transform) as GameObject;
            obstacle.transform.localPosition = new Vector2(initialX, initialY);

            initialX += 3f;
        }
    }
}
