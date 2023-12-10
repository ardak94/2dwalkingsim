using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShootingSC : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletPos;
    public float cooldown;

    private float timer;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
 
        float distance = Vector2.Distance(transform.position, player.transform.position);

        
        if (distance < 12)
        {
            timer += Time.deltaTime;
            if (timer > cooldown)
            {
                timer = 0;
                shoot();
            }
            
        }

    }

    void shoot()
    {
        Instantiate(bullet, bulletPos.position, Quaternion.identity);
    }
    
}
