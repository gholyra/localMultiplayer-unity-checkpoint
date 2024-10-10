using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

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

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Update()
    {
        HandleWalk();
    }

    private void HandleWalk()
    {
        float inputValue = InputManager.Instance.GetMovementVector();

        moveDirection.x = inputValue;
        rigidBody.velocity = new Vector2(moveDirection.x * velocity, rigidBody.velocity.y);
    }
}
