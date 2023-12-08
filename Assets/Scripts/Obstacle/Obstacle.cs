using UnityEngine;

/// <summary>
/// This script is used to manage the obstacles.
/// </summary>
public class Obstacle : Entity
{
    /// <summary>
    /// The endurance of the obstacle.
    /// </summary>
    private float endurance = 10f;
    protected override float Existence
    {
        get { return endurance; }
        set { endurance = value; }
    }

    public float Endurance
    {
        get { return endurance; }
        set { endurance = value; }
    }

    float totalEndurance = 0f;

    GameObject obstacleSprite;

    [SerializeField]
    Sprite brownSprite;

    [SerializeField]
    Sprite yellowSprite;

    [SerializeField]
    Sprite greenSprite;

    void Start()
    {
        obstacleSprite = transform.GetChild(0).gameObject;
        totalEndurance = Endurance;
    }

    void Update()
    {
        float percentage = Existence / totalEndurance;
        if (percentage <= 0.25f)
        {
            obstacleSprite.GetComponent<SpriteRenderer>().sprite = brownSprite;
        }
        else if (percentage <= 0.5f)
        {
            obstacleSprite.GetComponent<SpriteRenderer>().sprite = yellowSprite;
        }
        else if (percentage <= 0.75f)
        {
            obstacleSprite.GetComponent<SpriteRenderer>().sprite = greenSprite;
        }
    }
}
