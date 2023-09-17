using UnityEngine;

public class PlayerShot : Shot
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }
    }
}
