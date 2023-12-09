using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{

    private ScoreManager skorsaymakodu;
    
    private void Start()
    {
        skorsaymakodu = GameObject.Find("CoinSayar").GetComponent<ScoreManager>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            skorsaymakodu.score += 1f;
            Destroy(gameObject);
        }
    }
}
