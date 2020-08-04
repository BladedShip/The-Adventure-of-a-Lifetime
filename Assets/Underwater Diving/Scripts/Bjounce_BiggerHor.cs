using UnityEngine;
using System;
using System.Collections;

public class Bjounce_BiggerHor : MonoBehaviour
{
    float PosOriginal;
    public float Strength = 1;
    void Start()
    {
        this.PosOriginal = this.transform.position.x;
    }

    void Update()
    {
        transform.position = new Vector3(PosOriginal+((float)Math.Sin(Time.time)/2*Strength), transform.position.y, transform.position.z);
    }
}