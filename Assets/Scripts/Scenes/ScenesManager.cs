using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenesManager : MonoBehaviour
{
    public static ScenesManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    
    public enum Scene
    {
        Main,
        Lvl1,
        Lvl2,
        Lvl3,
        Lvl4,
    }

    public void LoadScene(Scene sceneplaceholder)
    {
        SceneManager.LoadScene(sceneplaceholder.ToString());
    }

    public void LoadNewGame()
    {
        SceneManager.LoadScene(Scene.Lvl1.ToString());
    }

    public void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.Main.ToString());
    }

    public void LoadExit()
    {
        Application.Quit();
        UnityEditor.EditorApplication.isPlaying = false;
    }
    
    
}
