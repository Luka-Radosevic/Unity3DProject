using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject transitionScreen, mainMenu, settings, description;
    public string sceneName;

    void Start()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }

    public void playGame()
    {
        transitionScreen.SetActive(true);
        SceneManager.LoadScene(sceneName);
    }

    public void settingsMenu()
    {
        mainMenu.SetActive(false);
        settings.SetActive(true);
    }

    public void descriptionMenu()
    {
        mainMenu.SetActive(false);
        description.SetActive(true);
    }

    public void quitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void backToMainMenu()
    {
        settings.SetActive(false);
        description.SetActive(false);
        mainMenu.SetActive(true);
    }
}
