using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public ParticleSystem patlaanim;
    public ParticleSystem dashanim;
    public ParticleSystem healanim;
    public ParticleSystem maxhealthupanim;
    public ParticleSystem takedmganim;

    private void Start()
    {
        patlaanim.Pause();
        dashanim.Pause();
        healanim.Pause();
        maxhealthupanim.Pause();
        takedmganim.Pause();
    }
}
