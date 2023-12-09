using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UILvl1 : MonoBehaviour
{
    [SerializeField] Button _mainMenu;
    [SerializeField] Button _nextLevel;
    private void Start()
    {
        _mainMenu.onClick.AddListener(MainMenu);
        _nextLevel.onClick.AddListener(NextLevel);

    }

    private void MainMenu()
    {
        //ScenesManager.Instance.LoadScene(ScenesManager.Scene.Main);
        ScenesManager.Instance.LoadMainMenu();
    }

    private void NextLevel()
    {
        ScenesManager.Instance.LoadNextScene();
    }
    
    
}
