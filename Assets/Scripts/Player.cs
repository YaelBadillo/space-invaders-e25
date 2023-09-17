using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float life;
    [SerializeField] private int lives;
    [SerializeField] private GameObject liveSprites;
    [SerializeField] private float speed;
    private PlayerActions playerActions;
    private Rigidbody2D playerRigidbody;
    private Vector2 moveInput;

    void Awake()
    {
        playerActions = new PlayerActions();

        playerRigidbody = GetComponent<Rigidbody2D>();
        if (playerRigidbody is null)
            Debug.LogWarning("Rigidbody2D is null");
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

    public void TakeDamage(float damage)
    {
        life -= damage;
        if (life <= 0f)
        {
            ToRevive();
            lives--;
            Transform live = liveSprites.transform.GetChild(0);
            Destroy(live.gameObject);
        }
    }

    private void ToRevive() {
        transform.position = new Vector3(0f, transform.position.y);
    }
}
