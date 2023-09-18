using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public string sceneName;
    public int sceneNumber;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("level", sceneNumber);
            PlayerPrefs.Save();
            SceneManager.LoadScene(sceneName);
        }
    }
}
