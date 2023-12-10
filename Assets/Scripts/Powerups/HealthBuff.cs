using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "HealthBuff")]
public class HealthBuff : PowerupEffect
{
    public float amount;
    public override void Apply(GameObject target)
    {
        target.GetComponent<HealthManager>().Heal(amount);
    }
    
}
