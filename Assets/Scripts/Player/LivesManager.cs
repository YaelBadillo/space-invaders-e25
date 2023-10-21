using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Manages the lives of the player.
/// </summary>
public class LivesManager : MonoBehaviour
{
    /// <summary>
    /// The number of lives the player has.
    /// </summary>
    [SerializeField] private int _lives = 3;
    public int Lives => _lives;
    /// <summary>
    /// The live sprites.
    /// </summary>
    [SerializeField] private GameObject liveSprites;

    /// <summary>
    /// Called when the player dies.
    /// </summary>
    public void LoseALife()
    {
        ToRevive();
        _lives--;
        if (liveSprites.transform.childCount > 0)
        {

            Transform live = liveSprites.transform.GetChild(0);
            Destroy(live.gameObject);
        }
    }

    /// <summary>
    /// Called when the player loses a live.
    /// </summary>
    private void ToRevive()
    {
        transform.position = new Vector3(0f, transform.position.y);
    }
}
