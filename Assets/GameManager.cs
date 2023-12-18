using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LootLocker.Requests;
using TMPro;
using UnityEngine.Networking;

public class GameManager : MonoBehaviour
{

    public TMP_InputField PlayerNameInputField, XpIncreaseInputField;
    public TMP_Text CurrentLevelText, XPText, NextLevelText;
    public GameObject CreatePlayerButton, loginButton, ItemPrefab;
    private Guid currentDeviceID;
    public Slider LvlSlider;
    public Transform InventoryList;
    
    



    
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
                CheckXp();
                PlayerInventory();
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
                CheckXp();
                PlayerInventory();
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
            CheckXp();
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
                CheckXp();
                PlayerInventory();
            }
            else
            {
                Debug.Log("Failed" + response.errorData); 
            }
        });

    }
    
    public void CheckXp()
    {
        LootLockerSDKManager.GetPlayerProgression("arda", response =>
        {
            if (response.success)
            {
                CurrentLevelText.text = response.step.ToString();
                XPText.text = (response.points - response.previous_threshold)  + " / " + (response.next_threshold - response.previous_threshold);
                
                NextLevelText.text = (response.step + 1).ToString();

                if (LvlSlider.value == LvlSlider.maxValue)
                {
                    LvlSlider.maxValue = (float)response.next_threshold - response.previous_threshold;
                    LvlSlider.value = 0;
                }
                else
                {
                    LvlSlider.value = (response.points - response.previous_threshold);
                }
                
            }
        });
    }

    public void PlayerInventory()
    {
        LootLockerSDKManager.GetInventory((response) =>
            {
                if (response.success)
                {
                    foreach (Transform child in InventoryList)
                    {
                        Destroy(child.gameObject);
                    }

                    LootLockerInventory[] items = response.inventory;
                    for (int i = 0; i < items.Length; i++)
                    {
                        GameObject ChildObject = Instantiate(ItemPrefab, InventoryList);
                        ChildObject.transform.parent = InventoryList;
                        ChildObject.GetComponent<itemData>().ItemNameString = items[i].asset.name.ToString();
                        ChildObject.name = items[i].asset.name.ToString();

                        LootLockerFile[] assetFile = items[i].asset.files;
                        StartCoroutine(LoadTexture(assetFile[0].url.ToString(),
                            ChildObject.GetComponent<itemData>().ItemIcon));
                    }
                }
                else
                {
                    Debug.Log("Failed" + response.errorData);
                }
            }
            );
    }

    private IEnumerator LoadTexture(string ImageURL, Image IconImage)
    {
        UnityWebRequest www = UnityWebRequestTexture.GetTexture(ImageURL);
        yield return www.SendWebRequest();

        Texture2D LoadTexture = DownloadHandlerTexture.GetContent(www);
        IconImage.sprite =
            Sprite.Create(LoadTexture, new Rect(0f, 0f, LoadTexture.width, LoadTexture.height), Vector2.zero);
    }
}
