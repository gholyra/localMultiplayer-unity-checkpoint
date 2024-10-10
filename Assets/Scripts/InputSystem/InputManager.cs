using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Instance;

    private GameControls gameControls;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        gameControls = new GameControls();
        gameControls.PlayerOne.Enable();
        gameControls.PlayerTwo.Enable();
    }

    public Vector2 GetMovementVector2D(int playerType)
    {
        Vector2 inputVector = new Vector2();

        switch (playerType)
        {
            case 0:
                inputVector = gameControls.PlayerOne.Walk.ReadValue<Vector2>();
                break;
            case 1:
                inputVector = gameControls.PlayerTwo.Walk.ReadValue<Vector2>();
                break;
        }

        return inputVector.normalized;
    }

}
