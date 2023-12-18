using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonInfo : MonoBehaviour
{
    public int ItemID;
    public TMP_Text PriceTxt;
    public TMP_Text QuantityTxt;
    public GameObject Shopmanager;
    
    void Update()
    {
        PriceTxt.text = "Price: $" + Shopmanager.GetComponent<ShopManager>().shopItems[2, ItemID].ToString();
        QuantityTxt.text = Shopmanager.GetComponent<ShopManager>().shopItems[3, ItemID].ToString();

    }
}
