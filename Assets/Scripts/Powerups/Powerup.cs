using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powerup : MonoBehaviour
{
    public PowerupEffect powerupEffectoo;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObject);
        powerupEffectoo.Apply(other.gameObject);
        
    }
}