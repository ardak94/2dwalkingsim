using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyThinker : MonoBehaviour
{

    public Brain brain;
    private void Update()
    {
        brain.Think(this);


    }
}
