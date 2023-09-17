using UnityEngine;

public class LoopingBackgroundImage : MonoBehaviour
{
    public float backgroundImageSpeed;
    public Renderer backgroundImageRenderer;

    void Update()
    {
        backgroundImageRenderer.material.mainTextureOffset += new Vector2(0f, backgroundImageSpeed * Time.deltaTime);
    }
}
