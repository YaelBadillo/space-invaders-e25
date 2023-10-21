using UnityEngine;

/// <summary>
/// This script is used to move the player.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// The speed of the player.
    /// </summary>
    [SerializeField] private float speed;
    /// <summary>
    /// The player actions.
    /// </summary>
    private PlayerActions playerActions;
    /// <summary>
    /// The player's Rigidbody2D.
    /// </summary>
    private Rigidbody2D playerRigidbody;
    private Vector2 moveInput;

    /// <summary>
    /// Called when the player is instantiated to get player actions for movement.
    /// </summary>
    void Awake()
    {
        playerActions = new PlayerActions();

        playerRigidbody = GetComponent<Rigidbody2D>();
        if (playerRigidbody is null)
            Debug.LogWarning("A Rigidbody2D is required");
    }

    private void OnEnable()
    {
        playerActions.Player_Map.Enable();
    }

    private void OnDisable()
    {
        playerActions.Player_Map.Disable();
    }

    /// <summary>
    /// Called every fixed framerate frame.
    /// </summary>
    void FixedUpdate()
    {
        moveInput = playerActions.Player_Map.Movement.ReadValue<Vector2>();
        moveInput.y = 0f;
        playerRigidbody.velocity = moveInput * speed;
    }
}
