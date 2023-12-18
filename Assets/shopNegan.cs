using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shopNegan : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.tag == "Player")
            {
                ScenesManager.Instance.LoadShop();
            }
        }
}
