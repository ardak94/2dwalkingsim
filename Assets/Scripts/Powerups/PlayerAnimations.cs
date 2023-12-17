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
    public ParticleSystem doublejumpanimF;
    public ParticleSystem doublejumpanimW;
    public ParticleSystem doublejumpanimE;
    public ParticleSystem doublejumpanimA;


    private void Start()
    {
        patlaanim.Pause();
        dashanim.Pause();
        healanim.Pause();
        maxhealthupanim.Pause();
        takedmganim.Pause();
        doublejumpanimF.Pause();
        doublejumpanimW.Pause();
        doublejumpanimE.Pause();
        doublejumpanimA.Pause();
    }
}
