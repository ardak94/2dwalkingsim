using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Skills : MonoBehaviour
{
    private PlayerAnimations animasyonlar;
    public float skillset = 1;
    public Transform AimV1;
    public Transform AimRight;
    public Transform AimUp;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    
    public GameObject primaryPrefabF;
    public GameObject primaryPrefabW;
    public GameObject primaryPrefabE;
    public GameObject primaryPrefabA;
    public float cooldownPrimary = 1;
    public float speedPrimary = 10;
    public float primaryJump = 12f;
    
    public GameObject secondaryPrefabF;
    public GameObject secondaryPrefabW;
    public GameObject secondaryPrefabE;
    public GameObject secondaryPrefabA;
    public float cooldownSecondary = 1;
    public float speedSecondary = 10;
    public float secondJump = 12f;
    public float secondJumpTime = 0.5f;
    
    public GameObject thirdPrefabF;
    public GameObject thirdPrefabW;
    public GameObject thirdPrefabE;
    public GameObject thirdPrefabA;
    public float cooldownThird;
    public float thirdJump = 12f;





    private float timer2;
    private float timer3;
    private GameObject enemy;
 

    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy");
        animasyonlar = GameObject.FindGameObjectWithTag("AnimManagerTag").GetComponent<PlayerAnimations>();
    }
    
//FIRE//
    private void shootPrimaryF()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabF, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabF, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
            
        }
    }
        
    private void shootSecondaryF()
    {        
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabF, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabF, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
    }
    
    private void shootThirdF()
    { 
        var bullet = Instantiate(thirdPrefabF, AimV1.position, AimV1.rotation);
    }
    
    //WATER//
    private void shootPrimaryW()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabW, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabW, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
            
        }
    }
        
    private void shootSecondaryW()
    {        
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabW, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabW, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
    }
    
    private void shootThirdW()
    { 
        var bullet = Instantiate(thirdPrefabW, AimV1.position, AimV1.rotation);
    }
    
    
    
    //EARTH//
    private void shootPrimaryE()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabE, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabE, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
            
        }
    }
        
    private void shootSecondaryE()
    {        
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabE, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabE, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
    }
    
    private void shootThirdE()
    { 
        var bullet = Instantiate(thirdPrefabE, AimV1.position, AimV1.rotation);
    }
    
    //AIR//
    private void shootPrimaryA()
    {

        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabA, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(primaryPrefabA, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
            
        }
    }
        
    private void shootSecondaryA()
    {        
        if (Input.GetKey(KeyCode.Space))
        {
            Vector3 direction = AimUp.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabA, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
        else
        {
            Vector3 direction = AimRight.transform.position - AimV1.transform.position;
            var bullet = Instantiate(secondaryPrefabA, AimV1.position, AimV1.rotation);
            float rot = Mathf.Atan2(-direction.y, -direction.x) * Mathf.Rad2Deg;
            bullet.transform.rotation = Quaternion.Euler(0,0, rot + 180);
            bullet.GetComponent<Rigidbody2D>().velocity = new Vector2(direction.x, direction.y).normalized * speedPrimary;
        }
    }
    
    private void shootThirdA()
    { 
        var bullet = Instantiate(thirdPrefabA, AimV1.position, AimV1.rotation);
    }
    
    
        


    void Update()
    {
        timer2 += Time.deltaTime;
        timer3 += Time.deltaTime;
        
        if (Input.GetKeyDown(KeyCode.E))
        {
            rb.velocity = new Vector2(primaryJump, rb.velocity.y);
            if (skillset == 1)
            {
                shootPrimaryF();
            }
            
            if (skillset == 2)
            {
                shootPrimaryW();
            }
            
            if (skillset == 3)
            {
                shootPrimaryE();
            }
            
            if (skillset == 4)
            {
                shootPrimaryA();
            }
            
            
        }
            
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (timer2 > cooldownSecondary)
            {
                timer2 = 0;
                rb.velocity = new Vector2(secondJump,rb.velocity.y);
                if (skillset == 1)
                {
                    shootSecondaryF();
                }
            
                if (skillset == 2)
                {
                    shootSecondaryW();
                }
            
                if (skillset == 3)
                {
                    shootSecondaryE();
                }
            
                if (skillset == 4)
                {
                    shootSecondaryA();
                }

            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (IsGrounded())
            {
                if (timer3 > cooldownThird)
                {
                    timer3 = 0;
                    rb.velocity = new Vector2(rb.velocity.x, thirdJump);
                    
                    if (skillset == 1)
                    {
                        shootThirdF();
                    }
            
                    if (skillset == 2)
                    {
                        shootThirdW();
                    }
            
                    if (skillset == 3)
                    {
                        shootThirdE();
                    }
            
                    if (skillset == 4)
                    {
                        shootThirdA();
                    }

                    
                    
                }
                
            }
            else
            {
                if (timer3 > cooldownThird)
                {
                    timer3 = 0;
                    rb.velocity = new Vector2(rb.velocity.x, thirdJump);
                    if (skillset == 1)
                    {
                        animasyonlar.doublejumpanimF.Play();
                    }
            
                    if (skillset == 2)
                    {
                        animasyonlar.doublejumpanimW.Play();
                    }
            
                    if (skillset == 3)
                    {
                        animasyonlar.doublejumpanimE.Play();
                    }
            
                    if (skillset == 4)
                    {
                        animasyonlar.doublejumpanimA.Play();
                    }

                }
            }            
            
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            skillset += 1;
            if (skillset > 4)
            {
                skillset = 1;
            }
            Debug.Log("skillset =" + skillset);
            if (skillset == 1)
            {
                animasyonlar.state1.Play();
            }
            if (skillset == 2)
            {
                animasyonlar.state2.Play();
            }
            if (skillset == 3)
            {
                animasyonlar.state3.Play();
            }
            if (skillset == 4)
            {
                animasyonlar.state4.Play();
            }

        }    

    }
    
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }


}
