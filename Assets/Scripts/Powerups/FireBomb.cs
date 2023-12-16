using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class FireBomb : MonoBehaviour
{
    private PlayerAnimations animasyonlar;
 

    private void Start()
    {
        animasyonlar = GameObject.FindGameObjectWithTag("AnimManagerTag").GetComponent<PlayerAnimations>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            animasyonlar.patlaanim.Play();
            
        }
        
    }
        
        

    
    public void OnTriggerEnter2D(Collider2D otherCollider2D)
    {

        
        if (otherCollider2D.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            animasyonlar.patlaanim.Play();

        }
    }
}