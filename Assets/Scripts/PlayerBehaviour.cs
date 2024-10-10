using UnityEngine;

[System.Flags]
public enum PlayerType
{
    PlayerOne, PlayerTwo
}

public class PlayerBehaviour : MonoBehaviour
{
    public static PlayerBehaviour Instance;

    [SerializeField] float velocity = 3f;

    private Vector2 moveDirection;
    private Rigidbody2D rigidBody;
    private int playerType;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        if (this.gameObject.CompareTag("PlayerOne"))
        {
            playerType = 0;
        }
        else if (this.gameObject.CompareTag("PlayerTwo"))
        {
            playerType = 1;
        }
    }

    private void Update()
    {
        HandleWalk();
    }

    private void HandleWalk()
    {
        Vector2 inputValue = InputManager.Instance.GetMovementVector2D(playerType);

        moveDirection.x = inputValue.x;
        moveDirection.y = inputValue.y;
        
        rigidBody.velocity = new Vector2(moveDirection.x * velocity, moveDirection.y * velocity);
    }
}
