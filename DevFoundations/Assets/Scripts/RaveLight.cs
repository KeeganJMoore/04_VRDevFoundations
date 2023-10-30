using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using Random = UnityEngine.Random;

public class RaveLight : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("RotateColorLight",1f,0.15f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void RotateColorLight()
    {
        transform.rotation = Quaternion.Euler(90,0,0);
        transform.Rotate(Random.Range(-20,20),0,0);
        Light raveLightColor = gameObject.GetComponentInChildren<Light>();
        raveLightColor.color = Random.ColorHSV();
    }
}
