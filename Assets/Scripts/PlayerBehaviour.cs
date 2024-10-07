using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    public static PlayerBehaviour Instance;

    [SerializeField] float speed;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

}
