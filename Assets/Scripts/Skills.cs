using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Skills : MonoBehaviour
{
    private PlayerAnimations animasyonlar;
    public Transform AimV1;
    public Transform AimRight;
    public Transform AimUp;
    public GameObject primaryPrefab;
    public float cooldownPrimary = 1;
    public float speedPrimary = 10;
    public GameObject secondaryPrefab;
    public float cooldownSecondary = 1;
    public float speedSecondary = 10;
    public GameObject thirdPrefab;
    public float cooldownThird;

    private float timer2;
    private float timer3;
    private GameObject enemy;
 
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        animasyonlar = GameObject.FindGameObjectWithTag("AnimManagerTag").GetComponent<PlayerAnimations>();
           
    }


    private void shootPrimary()
    {
        
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefab, AimV1.position, AimV1.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefab, AimV1.position, AimV1.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
    }
        
    private void shootSecondary()
    {        
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefab, AimV1.position, AimV1.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefab, AimV1.position, AimV1.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
    }
    
    private void shootThird()
    { 
        var bullet = Instantiate(thirdPrefab, AimV1.position, AimV1.rotation);
    }
    
        


    void Update()
    {
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            shootPrimary();
        }
            
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (timer2 > cooldownSecondary)
            {
                timer2 = 0;
                shootSecondary();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (timer3 > cooldownThird)
            {
                timer3 = 0;
                shootThird();
            }
            
        }

    }


}
