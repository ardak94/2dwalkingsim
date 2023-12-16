using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class PowerupTemplate : MonoBehaviour
{
    public float R = 255f;
    public float G = 255f;
    public float B = 255f;
    private void RenkDegistir(GameObject other)
    {
        other.GetComponent<SpriteRenderer>().color = new Color(R, G, B);
    }
    
    public void OnTriggerEnter2D(Collider2D otherCollider2D)
    {
        if (otherCollider2D.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            RenkDegistir(otherCollider2D.gameObject);
        }
    }
}