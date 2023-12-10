using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;


public abstract class PowerupEffect : ScriptableObject
{
    public abstract void Apply(GameObject target);
}
