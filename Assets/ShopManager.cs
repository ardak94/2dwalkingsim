using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShopManager : MonoBehaviour
{
    public int[,] shopItems = new int[6,6];
    public float coins;
    public TMP_Text CoinsTXT;
    
    
    
    void Start()
    {
        CoinsTXT.text = "Coins:" + coins.ToString();

        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;
        shopItems[1, 5] = 5;
        
        //PRICE
        
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 20;
        shopItems[2, 3] = 30;
        shopItems[2, 4] = 40;
        shopItems[2, 5] = 50;
        
        //QUANTITY
        
        shopItems[3, 1] = 1;
        shopItems[3, 2] = 1;
        shopItems[3, 3] = 1;
        shopItems[3, 4] = 1;
        shopItems[3, 5] = 1;
    }

    public void buy()
    {
        GameObject buttonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>()
            .currentSelectedGameObject;

        if (coins >= shopItems[2, buttonRef.GetComponent<ButtonInfo>().ItemID])
        {
            coins -= shopItems[2, buttonRef.GetComponent<ButtonInfo>().ItemID];

            shopItems[3, buttonRef.GetComponent<ButtonInfo>().ItemID] += 1;
            CoinsTXT.text = "Coins:" + coins.ToString();
            buttonRef.GetComponent<ButtonInfo>().QuantityTxt.text =
                shopItems[3, buttonRef.GetComponent<ButtonInfo>().ItemID].ToString();
        }
        
    }
    void Update()
    {
        
    }
}
