using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public string startSceneName;
    public GameObject settings;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void StartGame()
    {
        SceneManager.LoadScene(startSceneName);
    }
    public void ShowSettings()
    {
        settings.SetActive(true);
    }
    public void HideSettings()
    {
        settings.SetActive(false);
    }
}
