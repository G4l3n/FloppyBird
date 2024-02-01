using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInput : MonoBehaviour
{
    private PlayerMovement playerMovement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnJump(InputAction.CallbackContext value)
    {
        if (value.started)
        {
            playerMovement.Jump();
        }
        if (value.performed)
        {
            playerMovement.Jump();
        }
        if (value.canceled)
        {

        }
    }

}
