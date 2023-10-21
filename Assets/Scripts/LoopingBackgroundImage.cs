using UnityEngine;

/// <summary>
/// This script is used to manage the looping background image.
/// </summary>
public class LoopingBackgroundImage : MonoBehaviour
{
    /// <summary>
    /// The speed of the background image.
    /// </summary>
    public float backgroundImageSpeed;
    /// <summary>
    /// The background image renderer.
    /// </summary>
    public Renderer backgroundImageRenderer;

    void Update()
    {
        backgroundImageRenderer.material.mainTextureOffset += new Vector2(0f, backgroundImageSpeed * Time.deltaTime);
    }
}
