using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LivesManager : MonoBehaviour
{
    [SerializeField] private int _lives = 3;
    public int Lives => _lives;
    [SerializeField] private GameObject liveSprites;

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

    private void ToRevive()
    {
        transform.position = new Vector3(0f, transform.position.y);
    }
}
