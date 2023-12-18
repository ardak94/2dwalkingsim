using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LootLocker.Requests;
using TMPro;

public class GameManager : MonoBehaviour
{

    public TMP_InputField PlayerNameInputField, XpIncreaseInputField;
    public TMP_Text LevelText, XPText;
    public GameObject CreatePlayerButton, loginButton;
    private Guid currentDeviceID;



    
    public void CreatePlayer()
    {
        currentDeviceID = Guid.NewGuid();
        PlayerPrefs.SetString("GUID", currentDeviceID.ToString());

        LootLockerSDKManager.StartGuestSession(currentDeviceID.ToString(), (response) =>
        {
            if (response.success)
            {
                LootLockerSDKManager.SetPlayerName(PlayerNameInputField.text, null);
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed" + response.errorData);
            }
        });
    }

    public void Login()
    {
        LootLockerSDKManager.StartGuestSession(PlayerPrefs.GetString("GUID", ""), response =>
        {
            if (response.success)
            {
                CreatePlayerButton.SetActive(false);
                loginButton.SetActive(false);
                PlayerNameInputField.gameObject.SetActive(false);
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed" + response.errorData);
            }
        });

    }

    public void Exmachina()
    {
        string progressionKey = "arda";

        LootLockerSDKManager.ResetPlayerProgression(progressionKey, response =>
        {
            if (!response.success) {
                Debug.Log("Failed: " + response.errorData);
            }
    
            // Player level is now 1 
            Debug.Log($"Player is level {response.step} since the {response.progression_name} was reset");
        });
    }
    
    public void GiveXp()
    {
        
        LootLockerSDKManager.AddPointsToPlayerProgression("arda",8 , (response) =>
        {
            if (response.success)
            {
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed" + response.errorData); 
            }
        });
    }
    
    
    public void GetXp()
    {
        LootLockerSDKManager.GetPlayerProgression("arda", response =>
        {
            if (response.success)
            {
                LevelText.text = $"Level:{response.step}";
                XPText.text = $"XP:{response.points}";
            }


        });
    }
   

}
