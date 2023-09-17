using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    private PlayerActions playerActions;
    private Rigidbody2D playerRigidbody;
    private Vector2 moveInput;

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

    void FixedUpdate()
    {
        moveInput = playerActions.Player_Map.Movement.ReadValue<Vector2>();
        moveInput.y = 0f;
        playerRigidbody.velocity = moveInput * speed;
    }
}
