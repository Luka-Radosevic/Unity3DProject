using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu, settings;
    public string sceneName;
    public bool toggle;
    public Movement playerScript;
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            toggle = !toggle;
            if(toggle == false)
            {
                pauseMenu.SetActive(false);
                AudioListener.pause = false;
                Time.timeScale = 1;
                playerScript.enabled = true;
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            if(toggle == true)
            {
                pauseMenu.SetActive(true);
                AudioListener.pause = true;
                Time.timeScale = 0;
                playerScript.enabled = false;
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    public void resumeGame()
    {
        toggle = false;
        pauseMenu.SetActive(false);
        AudioListener.pause = false;
        Time.timeScale = 1;
        playerScript.enabled = true;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void settingsMenu()
    {
        pauseMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void backToPause()
    {
        settings.SetActive(false);
        pauseMenu.SetActive(true);
    }

    public void quitToMenu()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        SceneManager.LoadScene(sceneName);
    }

    public void quitToDesktop()
    {
        Time.timeScale = 1;
        AudioListener.pause = false;
        Debug.Log("alt f4");
        Application.Quit();
    }
}
