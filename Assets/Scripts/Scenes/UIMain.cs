using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UIMain : MonoBehaviour
{
    [SerializeField] Button _newGame;
    [SerializeField] Button _quit;
    private void Start()
    {
        _newGame.onClick.AddListener(StartNewGame);
        _quit.onClick.AddListener(Quit);
    }

    private void StartNewGame()
    {
        //ScenesManager.Instance.LoadScene(ScenesManager.Scene.Main);
        ScenesManager.Instance.LoadNewGame();
    }

    private void Quit()
    {
        ScenesManager.Instance.LoadExit();
    }

}
