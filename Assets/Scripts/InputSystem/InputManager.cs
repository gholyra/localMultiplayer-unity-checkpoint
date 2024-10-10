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

    public float GetMovementVector(string tag)
    {
        float inputVector = 0f;

        if (tag == PlayerType.PlayerOne)
        {
            inputVector = gameControls.PlayerOne.Walk.ReadValue<float>();
        }
        if (playerType == PlayerType.PlayerTwo)
        {
            inputVector = gameControls.PlayerTwo.Walk.ReadValue<float>();
        }
        return inputVector;
    }

}
