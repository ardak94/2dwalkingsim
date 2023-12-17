using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterThird : MonoBehaviour
{

    public float life = 10;

    private void Awake()
    {
        Destroy(gameObject, life);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);            
        }


    }
}