using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HealthNerf")]
public class HealthNerf : PowerupEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<HealthManager>().TakeDamage(amount);
    }
    
}
