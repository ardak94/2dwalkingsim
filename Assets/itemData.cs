using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class itemData : MonoBehaviour
{
    public TMP_Text ItemName;
    public string ItemNameString;
    public Image ItemIcon;


    private void Start()
    {
        ItemName.text = ItemNameString;
        ItemIcon.sprite = ItemIcon.sprite;
    }
}
