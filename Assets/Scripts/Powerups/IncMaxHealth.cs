using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "IncMaxHealth")]
public class IncMaxHealth : PowerupEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<HealthManager>().IncMaxHealth(amount);
    }
    
}
