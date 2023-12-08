using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeManager : MonoBehaviour
{
    [SerializeField]
    GameObject livesContainer;

    [SerializeField]
    GameObject lifePrefab;

    readonly int numberOfLives = 3;

    void Start()
    {
        Generate();
    }

    public void Generate()
    {
        livesContainer.transform.DetachChildren();

        float initialX = 0f;
        float initialY = 0f;

        for (int i = 0; i < numberOfLives; i++)
        {
            GameObject life = Instantiate(lifePrefab, livesContainer.transform) as GameObject;
            life.transform.localPosition = new Vector2(initialX, initialY);

            initialX += 1f;
        }
    }
}
