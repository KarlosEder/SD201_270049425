using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using System.Security.Cryptography.X509Certificates;
using UnityEngine.SceneManagement;
using StarterAssets;
using UnityEngine.UI;

public class pauseMenuScript : MonoBehaviour
{
    private PlayerControls playerControls;
    private InputAction menu;

    [SerializeField] private GameObject pauseUI;
    [SerializeField] private bool isPaused;
    [SerializeField] private StarterAssetsInputs player;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Awake()
    {
        playerControls = new PlayerControls();
    }

    void Update()
    {

    }

    private void OnEnable()
    {
        menu = playerControls.Menu.Escape;
        menu.Enable();

        menu.performed += Pause;
    }

    private void OnDisable()
    {
        menu.Disable();
    }

    void Pause(InputAction.CallbackContext context)
    {
        if (!isPaused)
        {
            ActivateMenu();
        }
        else
        {
            DeactivateMenu();
        }
    }

    void ActivateMenu()
    {
        AudioListener.pause = false;
        pauseUI.SetActive(true);

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;

        player.cursorInputForLook = false;  
        player.look = Vector2.zero;

        isPaused = true;
    }

    public void DeactivateMenu()
    {
        AudioListener.pause = false;
        pauseUI.SetActive(false);
        isPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;

        player.cursorInputForLook = true;
        isPaused = false;

        /* pauseMenuButton.ResetTrigger(null); */
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("mainMenu_01");

        Cursor.visible = true;
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}