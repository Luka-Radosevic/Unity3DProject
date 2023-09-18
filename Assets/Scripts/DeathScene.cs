using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScene : MonoBehaviour
{
    public string sceneName;
    public float timer;

    void Start()
    {
        StartCoroutine(loadtoMenu());
    }

    IEnumerator loadtoMenu()
    {
        yield return new WaitForSeconds(timer);
        SceneManager.LoadScene(sceneName);
    }
}
