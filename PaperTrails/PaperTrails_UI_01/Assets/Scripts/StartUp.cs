using StarterAssets;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class StartUp : MonoBehaviour
{
    [SerializeField] private GameObject startMessage;
    [SerializeField] private bool isPaused;
    [SerializeField] private StarterAssetsInputs player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        player.cursorInputForLook = false;
        player.look = Vector2.zero;
    }

    public void OnContinueClick()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player.cursorInputForLook = true;
    }

    void Update()
    {

    }

    void Pause(InputAction.CallbackContext context)
    {
        if (!isPaused)
        {
            ActivateMenu();
        }
    }

    void ActivateMenu()
    {
        startMessage.SetActive(true);    
        AudioListener.pause = true;
        
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        player.cursorInputForLook = false;
        player.look = Vector2.zero;

        isPaused = true;
    }
}
